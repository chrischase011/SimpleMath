using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMathDLL
{
    public class SimpleMath
    {
        public int n1;
        public int n2;

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

        // Get the median
        public double Median(double[] num)
        {
            double temp;
            int size = num.Length;
            double med = 0;
            int check = 0;
            //Sort ascending
            /*
            for(int i = 0; i < size; i++)
            {
                for(int j = i + 1; j < size; j++)
                {
                    if(num[j] < num[i])
                    {
                        temp =  num[i];
                        num[i] = num[j];
                        num[j] = temp;
                    }
                }
            }
            */
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

                /*
                check = (size / 2) + 1;
                med = num[check];
                */
            }

            return med;
        }

        public double Mode(double[] num)
        {
            double mode = 0.0f;



            return mode;
        }

        // Libs //

        /* Sorting */

        // Ascending
        public void SortAsc(double[] num)
        {
            double temp;
            int size = num.Length;
            for (int i = 0; i < size; i++)
            {
                for (int j = i + 1; j < size; j++)
                {
                    if (num[j] < num[i])
                    {
                        temp = num[i];
                        num[i] = num[j];
                        num[j] = temp;
                    }
                }
            }
            
        }
        public void SortAsc(int[] num)
        {
            int temp;
            int size = num.Length;
            for (int i = 0; i < size; i++)
            {
                for (int j = i + 1; j < size; j++)
                {
                    if (num[j] < num[i])
                    {
                        temp = num[i];
                        num[i] = num[j];
                        num[j] = temp;
                    }
                }
            }

        }

        public void SortAsc(float[] num)
        {
            float temp;
            int size = num.Length;
            for (int i = 0; i < size; i++)
            {
                for (int j = i + 1; j < size; j++)
                {
                    if (num[j] < num[i])
                    {
                        temp = num[i];
                        num[i] = num[j];
                        num[j] = temp;
                    }
                }
            }

        }
        // Descending
        public void SortDesc(double[] num)
        {
            double temp;
            int size = num.Length;
            for (int i = 0; i < size; i++)
            {
                for (int j = i + 1; j < size; j++)
                {
                    if (num[i] < num[j])
                    {
                        temp = num[i];
                        num[i] = num[j];
                        num[j] = temp;
                    }
                }
            }
        }

        public void SortDesc(int[] num)
        {
            int temp;
            int size = num.Length;
            for (int i = 0; i < size; i++)
            {
                for (int j = i + 1; j < size; j++)
                {
                    if (num[i] < num[j])
                    {
                        temp = num[i];
                        num[i] = num[j];
                        num[j] = temp;
                    }
                }
            }
        }
        public void SortDesc(float[] num)
        {
            float temp;
            int size = num.Length;
            for (int i = 0; i < size; i++)
            {
                for (int j = i + 1; j < size; j++)
                {
                    if (num[i] < num[j])
                    {
                        temp = num[i];
                        num[i] = num[j];
                        num[j] = temp;
                    }
                }
            }
        }

    }
}
