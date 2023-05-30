using System;

namespace VA_laba_3.Gauss
{
    public class Algorithm
    {
        private LinearSystem list = null;
        public event Action<LinearSystem, int> DoAfterIteration;

        public Algorithm(LinearSystem list)
        {
            this.list = list;
        }

        private bool CheckSystem(LinearSystem system)
        {
            if (system.Size < 2) return false;
            for (int i = 0; i < system.Size; i++)
            {
                if (system.Get(i).Size != (system.Size + 1))
                {
                    return false;
                }
            }
            return true;
        }

        public double[] Calculate()
        {
            if (list == null)
            {
                throw new Exception("LinearSystem instance equal null");
            }
            if (!CheckSystem(list))
            {
                throw new Exception("Incorrect system for Gauss Method");
            }

            // прямой ход
            int i = 0;
            for (; i < list.Size - 1; i++)
            {
                if (list.Get(i).Get(i) == 0)
                {
                    for (int i1 = i + 1; i1 < list.Size; i1++)
                    {
                        if (list.Get(i1).Get(i) != 0)
                        {
                            list.Swap(i, i1);
                            break;
                        }
                    }
                }

                for (int j = i + 1; j < list.Size; j++)
                {
                    double k = list.Get(j).FindCoefficient(list.Get(j).Get(i), list.Get(i).Get(i));
                    list.Get(j).Mul(k);
                    list.Get(j).AddEquation(list.Get(i));
                }

                DoAfterIteration?.Invoke(list, i+1);
            }

            double[] x = BackWalk2(list, i);
            return x;
        }

        // вычисление неизвестных
        private double[] BackWalk1(LinearSystem list)
        {
            double[] x = new double[list.Size];
            for (int i = list.Size - 1; i >= 0; i--)
            {
                double sum = 0.0;
                int j = list.Size - 1;
                for (; j > i; j--)
                {
                    sum += list.ItemAt(i, j) * x[j];
                }
                x[i] = (list.ItemAt(i, list.Size) - sum) / list.ItemAt(i, j);
            }
            return x;
        }

        // обратный ход Гаусса
        private double[] BackWalk2(LinearSystem list, int offset)
        {
            for (int i = list.Size - 1, step = 1; i >= 0; i--, step++)
            {
                list.Get(i).SetValue(list.Size, list.Get(i).Get(list.Size) / list.Get(i).Get(i));
                list.Get(i).SetValue(i, 1);

                for (int i1 = i - 1; i1 >= 0; i1--)
                {
                    double k = list.Get(i1).FindCoefficient(list.Get(i1).Get(i), list.Get(i).Get(i));
                    list.Get(i1).Mul(k);
                    list.Get(i1).AddEquation(list.Get(i));
                }

                DoAfterIteration?.Invoke(list, offset + step);
            }

            double[] x = new double[list.Size];
            for (int i = 0; i < list.Size; i++)
            {
                x[i] = list.Get(i).Get(list.Size);
            }

            return x;
        }
    }
}
