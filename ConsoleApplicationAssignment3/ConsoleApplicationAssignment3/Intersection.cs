using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationAssignment3
{
    class Intersection
    {
        public string Check(string inputA, string inputB)
        {
            SetToRange setToRangeA = null;
            SetToRange setToRangeB = null;

            if (inputA.Contains("..."))
            {
                setToRangeA = new SetToRange();
                setToRangeA.Convert(inputA);
            }

            if (inputB.Contains("..."))
            {
                setToRangeB = new SetToRange();
                setToRangeB.Convert(inputB);
            }

            #region both inputs contain ...
            if (setToRangeA != null && setToRangeB != null)
            {
                List<int> combinedIntsA = new List<int>();
                setToRangeA.IntsBefore.ForEach(combinedIntsA.Add);
                setToRangeA.IntsAfter.ForEach(combinedIntsA.Add);
                List<int> combinedIntsB = new List<int>();
                setToRangeB.IntsBefore.ForEach(combinedIntsB.Add);
                setToRangeB.IntsAfter.ForEach(combinedIntsB.Add);

                List<int> intersectionBeforeAfter = new List<int>();

                foreach (int item in combinedIntsA)
                {
                    if (combinedIntsB.Contains(item) && !intersectionBeforeAfter.Contains(item))
                    {
                        intersectionBeforeAfter.Add(item);
                    }
                }

                HashSet<int> intersection = new HashSet<int>();
                intersection.UnionWith(intersectionBeforeAfter);

                if (setToRangeA.Lowest < setToRangeB.Lowest)
                {
                    if (setToRangeB.Lowest - setToRangeA.Lowest < 100000)
                    {
                        for (int i = setToRangeA.Lowest; i <= setToRangeB.Lowest; i++)
                        {
                            intersection.Add(i);
                        }
                    }

                    else
                    {
                        return "Intersection contains over 100,000 numbers so it would take too long to calculate.";
                    }
                }

                else
                {
                    if (setToRangeA.Lowest - setToRangeB.Lowest < 100000)
                    {
                        for (int i = setToRangeB.Lowest; i <= setToRangeA.Lowest; i++)
                        {
                            intersection.Add(i);
                        }
                    }

                    else
                    {
                        return "Intersection contains over 100,000 numbers so it would take too long to calculate.";
                    }
                }

                if (setToRangeA.Highest < setToRangeB.Highest)
                {
                    if (setToRangeB.Highest - setToRangeA.Highest < 100000)
                    {
                        for (int i = setToRangeA.Highest; i <= setToRangeB.Highest; i++)
                        {
                            intersection.Add(i);
                        }
                    }

                    else
                    {
                        return "Intersection contains over 100,000 numbers so it would take too long to calculate.";
                    }
                }

                else
                {
                    if (setToRangeA.Highest - setToRangeB.Highest < 100000)
                    {
                        for (int i = setToRangeB.Highest; i <= setToRangeA.Highest; i++)
                        {
                            intersection.Add(i);
                        }
                    }

                    else
                    {
                        return "Intersection contains over 100,000 numbers so it would take too long to calculate.";
                    }
                }
            }
            #endregion

            return null;
        }
    }
}
