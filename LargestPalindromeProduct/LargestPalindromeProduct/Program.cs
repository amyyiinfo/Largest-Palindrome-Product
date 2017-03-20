using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestPalindromeProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            int product;
            bool isPalindrome;
            int maxProduct = 0;
            for (int i = 999; i > 99; i--)
            {
                for (int j = 999; j > 99; j--)
                {
                    product = i * j;
                    String strProduct = Convert.ToString(product);
                    int productLength = strProduct.Length;
                    //Console.WriteLine(product);
                    isPalindrome = true;
                    for (int x = 0; x < productLength / 2; x++)
                    {
                        if (!(strProduct.Substring(x, 1) == strProduct.Substring(productLength - 1 - x, 1)))
                        {
                            isPalindrome = false;
                            break;
                        }

                    }
                    if (isPalindrome)
                    {
                        if (product > maxProduct)
                        {
                            maxProduct = product;
                        }



                    }
                }

            }
            Console.WriteLine(maxProduct);
            Console.Read();
        }
    }
}