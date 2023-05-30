using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace VA_laba_3.Gauss
{
    public class LinearSystem
    {
        private List<MyEquation> list = new List<MyEquation>();
        public int Size => list.Count;

        public MyEquation Get(int index)
        {
            return list[index];
        }

        public void Swap(int i1, int i2)
        {
            if ((i1 < 0 || i1 >= list.Count) || (i2 < 0 || i2 >= list.Count))
                throw new Exception("Невозможно поменять ур-ия местами. Ур-ия вне системы. Проверьте передаваемые индексы");

            for (int i = 0; i < list.Count + 1; i++)
            {
                double tmp = list[i1].Get(i);
                list[i1].SetValue(i, list[i2].Get(i));
                list[i2].SetValue(i, tmp);
            }
        }

        public void Push(MyEquation elem)
        {
            list.Add(elem);
        }

        public double ItemAt(int i, int j)
        {
            return list[i].Get(j);
        }

        public override string ToString()
        {
            if (Size == 0) return "";

            Dictionary<int, char> dict = new Dictionary<int, char>
            {
                {0, '\u2070' },
                {1, '\u00B9' },
                {2, '\u00B2' },
                {3, '\u00B3' },
                {4, '\u2074' },
                {5, '\u2075' },
                {6, '\u2076' },
                {7, '\u2077' },
                {8, '\u2078' },
                {9, '\u2079' },
            };

            StringBuilder sbOut = new StringBuilder();

            for (int i = 0; i < Size; i++)
            {
                MyEquation tmp = Get(i);
                StringBuilder sbInner = new StringBuilder();

                for (int i1 = 0; i1 < tmp.Size - 2; i1++)
                {
                    if (tmp.Get(i) < 0)
                        sbInner.Append($"({string.Format("{0:F2}", tmp.Get(i1))})");
                    else
                        sbInner.Append($"{string.Format("{0:F2}", tmp.Get(i1))}");

                    var digits = (tmp.Size - i1 - 1)
                        .ToString()
                        .ToCharArray()
                        .Select(d => dict[d - 48]);

                    sbInner.Append($"•x{string.Concat(digits)}");
                    sbInner.Append($" + ");
                }

                if (tmp.Get(i) < 0)
                    sbInner.Append($"({string.Format("{0:F2}", tmp.Get(tmp.Size - 2))})");
                else
                    sbInner.Append($"{string.Format("{0:F2}", tmp.Get(tmp.Size - 2))}");

                
                sbInner.Append($" = {string.Format("{0:F2}", tmp.Get(tmp.Size - 1))}");

                sbOut.AppendLine(sbInner.ToString());
            }

            return sbOut.ToString();
        }
    }
}
