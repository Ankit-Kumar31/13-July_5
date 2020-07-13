using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, reverse_num = 0, remainder, temp;
            Console.WriteLine("Enter an integer");
            num= Convert.ToInt16(Console.ReadLine());
            temp =num;
            while (temp != 0)
            {
                remainder = temp % 10;
                reverse_num = reverse_num * 10 + remainder;
                temp /= 10;
            }
            if (reverse_num == num)
            {
                Console.WriteLine("The given integer is palindrome number");
            }
            else
            {
                Console.WriteLine("The given integer is not palindrome number");
            }
        }
    }
    }

