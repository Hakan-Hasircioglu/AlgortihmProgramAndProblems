using System;

namespace fermatProblem_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = toOneHundred();
            // to start with one hundred we assign the variable sum
            int fermatBefore = 0, sumAfterFermat = sum;
            int add = 0;
            int fermatAfter;
            // since the result is 3 digits, the limit is between 100-999
            for (int fermat = 100; fermat <= 999; fermat++)
            {
                add = fermat + 1;
                //Before
                // after 100, calculate the sum of the previous numbers in each number increment
                sumAfterFermat += fermat;
                fermatBefore = sumAfterFermat - fermat;
                //After
                // we assign to 0 the variable fermatAfter because we have to reset the previous loop calculation
                fermatAfter = 0;
                // as long as fermatAfter smaller or equal to fermatBefore we increase fermatAfter. 
                // if fermatSonrasi pass to fermatBefore we know new number doesn't correct number we break to loop.
                while (fermatAfter <= fermatBefore)
                {
                    // in the loop, to add numbers after the fermat number, we asssign the variable add. 
                    /*  when increase one this variable we get variable the fermatAfter and
                     * we summing the variable fermatAfter and the variable add then assign to fermatAfter
                     */
                    fermatAfter += add;
                    // if fermatBefore equal to fermatAfter, we print door no and equal values
                    if (fermatBefore == fermatAfter)
                    {
                        Console.WriteLine("fermat kapi no: {2} fermat oncesi: {1}, fermat sonrasi: {0}", fermatAfter, fermatBefore, fermat);
                        break;
                    }
                    add++;
                }
                fermatAfter = 0;
            }
        }
        private static int toOneHundred()
        {
            // we sum numbers from 1 to ninety-nine
            int sum = 0;
            for (int i = 1; i < 100; i++)
            {
                sum += i;
            }

            return sum;
        }
    }
}
