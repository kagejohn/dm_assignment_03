using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationAssignment3
{
    class Membership
    {
        public string Check(string inputA, string inputB)
        {
            if (inputA.Contains("..."))
            {
                SetToRange setToRangeInputA = new SetToRange();
                setToRangeInputA.Convert(inputA);

                if (CheckSetToRange(inputB, setToRangeInputA))
                {
                    return "input B is a member of input A";
                }
            }

            else if (inputA.Contains(inputB))
            {
                return "input B is a member of input A";
            }

            if (inputB.Contains("..."))
            {
                SetToRange setToRangeInputB = new SetToRange();
                setToRangeInputB.Convert(inputB);

                if (CheckSetToRange(inputA, setToRangeInputB))
                {
                    return "input A is a member of input B";
                }
            }

            else if (inputB.Contains(inputA))
            {
                return "input A is a member of input B";
            }

            return "false";
        }

        bool CheckSetToRange(string input, SetToRange setToRange)
        {
            bool intsBefore = setToRange.IntsBefore.Contains(Convert.ToInt32(input));
            bool intsAfter = setToRange.IntsAfter.Contains(Convert.ToInt32(input));
            bool inRange = false;

            if (setToRange.Lowest != Int32.MinValue && setToRange.Highest != Int32.MaxValue)
            {
                inRange = setToRange.Lowest < Convert.ToInt32(input) && Convert.ToInt32(input) < setToRange.Highest;
            }

            else if (setToRange.Lowest == Int32.MinValue)
            {
                inRange = Convert.ToInt32(input) < setToRange.Highest;
            }

            else if (setToRange.Highest == Int32.MaxValue)
            {
                inRange = setToRange.Lowest < Convert.ToInt32(input);
            }

            if (intsBefore || inRange || intsAfter)
            {
                return true;
            }

            return false;
        }
    }
}
