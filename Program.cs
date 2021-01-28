using System;
using System.Collections.Generic;
using SystePm.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Demo
{
    static class Program
    {
       
        
        static void Main()
        {
            int choice = 0;
            do
            {
                Console.WriteLine("=============== MAY TINH CA NHAN ==============");
                Console.WriteLine("1. Cong hai so.");
                Console.WriteLine("2. Tru hai so.");
                Console.WriteLine("3. Nhan hai so.");
                Console.WriteLine("4. Chia hai so.");
                Console.WriteLine("5. Chia lay du hai so.");
                Console.WriteLine("6. Tinh AB.");
                Console.WriteLine("0. Thoat.");
                
                string input = Console.ReadLine();
                choice = Convert.ToInt32(input);
                int a = 0, b = 0;
                switch (choice)
                {
                    case 0:
                        Console.WriteLine("========== HEN GAP LAI ===========");
                        break;

                    case 1:
                        Console.WriteLine("Nhap so nguyen a");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Nhap so nguyen b");
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"{a} + {b} = { a + b }");
                        break;

                    case 2:
                        Console.WriteLine("Nhap so nguyen a");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Nhap so nguyen b");
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"{a} - {b} = { a - b }");
                        break;


                    default:
                        Console.WriteLine("Nhap cac chuc nang tu 1 den 6!");
                        break;
                        break;

                }


            }

        }
    }
}
