using System;

namespace ReviewC
{
    public class SystemIOPractice
    {
        static void Main(string[] args)
        {
            int[] test = new int[5] { 8, 15, 2, 67, 100 };
            Console.WriteLine(ChallengeFive(test));
        }

        static int Challenge2()
        {
            bool isEnough = false;
            int userNum = 0;
            int sum = 0;
            while (!isEnough)
            {
                Console.WriteLine("Please enter a number between 2 and 10: ");
                string userInput = Console.ReadLine();
                try{
                    userNum = Convert.ToInt32(userInput);
                }
                catch
                {
                    Console.WriteLine("Invalid number entered.");
                }
                if(userNum < 2 || userNum > 10) 
                {
                    Console.WriteLine("Number is not within range.");
                }
                else
                {
                    isEnough = true;
                }
            }
            int[] numArray = new int[userNum];
            for(int i = 0; i < numArray.Length; i++)
            {
                bool isAcceptable = false;
                while(!isAcceptable)
                {
                Console.Write($"Enter number {i} of {userNum}");
                string userInput = Console.ReadLine();
                int testNum = ConvertStringToInt(userInput);
                if(testNum > 0)
                    {
                        numArray[i] = testNum;
                        sum += testNum;
                        isAcceptable = true;
                    }
                }
                
            }
            return sum / userNum;
            
        }

        static int ConvertStringToInt(string s)
        {
            int convertInt = 0;
            try
            {
                return convertInt = int.Parse(s); 
            }

            catch
            {
                Console.WriteLine("Unable to Parse Value. Zero Returned");
                return convertInt;
            }
        }

        static void PrintRhombus()
        {

        }

        static void ChallengeFour(int[] intArr)
        {
            //Completed with Kjell


            int intArrLength = intArr.Length;
            int tempValue = 0;
            int mostRepeatedIdx;
            //Each index for comparison
            for (int i = 0; i < intArrLength; i++)
            {
                int count = 0;
                // scan the array for the i value index.
                for (int q = 0; q < intArrLength; q++)
                {
                    if (intArr[q] == intArr[i])
                    {

                        count++;

                    }
                }

            }
            //iterate through the entire array
            //grab a value at i
            //we store that value somehow
            //we make sure we haven't already had that value
            //if it is a unique value, iterate with a second loop

            // First for loop will iterate through each indxElement //1
            // second will ALSO loop through the Array, counting the number of time idxElement occurs.  Keep that total.

            // look at the count and compare it to the previous count.  If it is more, then that becomes the most repeated.

        }

        public static int ChallengeFive(int[] arr)
        {
            int highestVal = arr[0];
            for(var i = 1; i  < arr.Length; i++)
            {
                if(arr[i] > highestVal)
                {
                    highestVal = arr[i];
                }
            }
            return highestVal;
        }
    }
}
