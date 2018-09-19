using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationAssignment3
{
    class SetToRange
    {
        public SetToRange()
        {
            IntsBefore = new List<int>();
            IntsAfter = new List<int>();
            Lowest = Int32.MinValue;
            Highest = Int32.MaxValue;
        }

        public List<int> IntsBefore { get; private set; }
        public List<int> IntsAfter { get; private set; }
        public int Lowest { get; private set; }
        public int Highest { get; private set; }

        private bool _dotsHappened = false;

        public void Convert(string input)
        {
            IEnumerable<int> output;

            if (input.First() == '{')
            {
                input = input.Substring(1);
            }
            if (input.Last() == '}')
            {
                input = input.Remove(input.Length - 1);
            }

            string[] inputStrings = input.Split(',');

            for (int i = 0; i < inputStrings.Length; i++)
            {
                string temp = inputStrings[i];

                if (temp != "...")
                {
                    if (!_dotsHappened)
                    {
                        IntsBefore.Add(System.Convert.ToInt32(temp));
                    }
                    else
                    {
                        IntsAfter.Add(System.Convert.ToInt32(temp));
                    }
                }
                if (temp == "...")
                {
                    _dotsHappened = true;
                }
                else if(IntsBefore.Count != 0)
                {
                    Lowest = IntsBefore.Last() + 1;
                }
                if (i == inputStrings.Length - 1 && IntsAfter.Count != 0)
                {
                    Highest = IntsAfter.First() - 1;
                }
            }
        }
    }
}
