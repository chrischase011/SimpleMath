using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleLibrary;

namespace SimpleMathDLL
{
    public class SimpleMath
    {
        public int n1;
        public int n2;
        public Libs lb = new Libs();
        public SimpleMath()
        {
            Console.WriteLine("##### SIMPLE MATH LIBRARY #####\n\n##### CREATED BY: CHRISTOPHER ROBIN CHASE #####");
        }
        public SimpleMath(int n1, int n2)
        {
            this.n1 = n1;
            this.n2 = n2;
        }
        //Addition
        public int Add(int n1, int n2)
        {
            return n1 + n2;
        }
        //Subtraction
        public int Subtract(int n1, int n2)
        {
            return n1 - n2;
        }
        //Multiplication
        public int Multiply(int n1, int n2)
        {
            return n1 * n2;
        }
        // Division
        public float Divide(int n1, int n2)
        {
            return (float) n1 / n2;
        }

        //Returns the remainder
        public int Mod(int n1, int n2)
        {
            return n1 % n2;
        }

        //Check if it is even number
        public bool isEven(int num)
        {
            if(num % 2 == 0)
            {
                return true;
            }
            return false;
        }

        // Check if it is odd number
        public bool isOdd(int num)
        {
            if (num % 2 == 0)
            {
                return false;
            }
            return true;
        }

        //Check if it is a prime number
        public bool isPrime(int num)
        {
            if(num <= 1)
            {
                return false;
            }

            for(int i = 2; i <= Math.Sqrt(num); i++)
            {
                if(num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        //Get the Mean
        public double Mean(double[] num)
        {
            double sum = 0;
            double ave = 0;

            for(int i = 0; i < num.Length;i++)
            {
                sum += num[i];

            }
            ave = sum / num.Length;

            return ave;
        }
        public int Mean(int[] num)
        {
            int sum = 0;
            int ave = 0;

            for (int i = 0; i < num.Length; i++)
            {
                sum += num[i];

            }
            ave = sum / num.Length;

            return ave;
        }
        public float Mean(float[] num)
        {
            float sum = 0;
            float ave = 0;

            for (int i = 0; i < num.Length; i++)
            {
                sum += num[i];

            }
            ave = sum / num.Length;

            return ave;
        }

        // Get the median
        public double Median(double[] num)
        {
            
            int size = num.Length;
            double med = 0;
            //Sort ascending using my SimpleLibrary.dll
            
            lb.SortAsc(num);
            // After sorting in ascending order, get the median
            for(int i = 0; i <= size; i++)
            {
                if(isOdd(size))
                {
                    med = num[(size / 2)];
                   
                }
                else
                {
                    med = (num[(size / 2) - 1] + num[size / 2]) / 2.0;
                }
            }

            return med;
        }

        public int Median(int[] num)
        {

            int size = num.Length;
            int med = 0;
            //Sort ascending using my SimpleLibrary.dll

            lb.SortAsc(num);
            // After sorting in ascending order, get the median
            for (int i = 0; i <= size; i++)
            {
                if (isOdd(size))
                {
                    med = num[(size / 2)];

                }
                else
                {
                    med = (num[(size / 2) - 1] + num[size / 2]) / (int)2.0;
                }
            }

            return med;
        }
        public float Median(float[] num)
        {

            int size = num.Length;
            float med = 0;
            //Sort ascending using my SimpleLibrary.dll

            lb.SortAsc(num);
            // After sorting in ascending order, get the median
            for (int i = 0; i <= size; i++)
            {
                if (isOdd(size))
                {
                    med = num[(size / 2)];

                }
                else
                {
                    med = (num[(size / 2) - 1] + num[size / 2]) / 2.0f;
                }
            }

            return med;
        }
        // Mode
        public int Mode(int[] num)
        {
            int count = 1, tempCount;
            int mode = num[0];
            int temp = 0;
            for (int i = 0; i < (num.Length - 1); i++)
            {
                temp = num[i];
                tempCount = 0;
                for (int j = 1; j < num.Length; j++)
                {
                    if (temp == num[j])
                        tempCount++;
                }
                if (tempCount > count)
                {
                    mode = temp;
                    count = tempCount;
                }
            }
            return mode;
        }

        public double Mode(double[] num)
        {
            int count = 1, tempCount;
            double mode = num[0];
            double temp = 0;
            for (int i = 0; i < (num.Length - 1); i++)
            {
                temp = num[i];
                tempCount = 0;
                for (int j = 1; j < num.Length; j++)
                {
                    if (temp == num[j])
                        tempCount++;
                }
                if (tempCount > count)
                {
                    mode = temp;
                    count = tempCount;
                }
            }
            return mode;
        }
        public float Mode(float[] num)
        {
            int count = 1, tempCount;
            float mode = num[0];
            float temp = 0;
            for (int i = 0; i < (num.Length - 1); i++)
            {
                temp = num[i];
                tempCount = 0;
                for (int j = 1; j < num.Length; j++)
                {
                    if (temp == num[j])
                        tempCount++;
                }
                if (tempCount > count)
                {
                    mode = temp;
                    count = tempCount;
                }
            }
            return mode;
        }

    }
}
