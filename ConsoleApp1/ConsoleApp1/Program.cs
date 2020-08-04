using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            if (false)
            {
                inch_print();   //inch-> cm
                pound_kg_print();   //파운드 -> 킬로그램
                circle_value_print(); //반지름 -> 원 둘레, 원 넓이.
            }
            calcurator2();
        }
        static void inch_print()
        {
            Console.WriteLine("인치를 cm단위로 변환하여 출력합니다.");
            var input = Console.ReadLine();
            double inch = 2.54;

            Console.WriteLine("input : " + input + " inch->cm");
            Console.WriteLine(double.Parse(input) * inch + " cm입니다.");
        }
        static void pound_kg_print()
        {
            Console.WriteLine("pound를 kg단위로 변환하여 출력합니다.");
            var input = Console.ReadLine();
            double pound = 2.20462262;

            Console.WriteLine("input : " + input + " pound->kg");
            Console.WriteLine(double.Parse(input) * pound + " kg입니다.");
        }
        static void circle_value_print()
        {
            Console.WriteLine("원의 반지름을 입력 받아 원의 둘레와 넓이를 구합니다.");
            var input = Console.ReadLine();
            double pi = 3.14;

            Console.WriteLine("input 반지름 : " + input + " 반지름 -> 원 둘레, 원 넓이");
            Console.WriteLine("원의 둘레는 " + double.Parse(input) * 2 * pi + " 입니다.");
            Console.WriteLine("원의 넓이는 " + double.Parse(input) * double.Parse(input) * pi + " 입니다.");
        }

        /*
         * 1. 입력값을 받아서 
           2. 문자열 접근으로 접근
           3. int 형으로 변경후 출력, 안됨. 
           4. 도합 계산시 그냥 계산해서 출력.or 자리수당 10씩 곱해서 출력
            */
        static void calcurator()
        {
            int input1 = int.Parse(Console.ReadLine());
            string input2 = Console.ReadLine();

            for (int i = input2.Length-1; i > -1; i--)
                Console.WriteLine(input1 * int.Parse(input2[i]+""));
            
            Console.WriteLine(input1 * int.Parse(input2));
            Console.ReadLine();
        }
        static void calcurator2()
        {
            int input1 = int.Parse(Console.ReadLine());
            string input2 = Console.ReadLine();

           /* int.Parse(input2)/1 % 10;//1자리
            int.Parse(input2)/10 % 10;//2자리
            int.Parse(input2)/100 % 10;//3자리*/
            for (int i = 0; i < input2.Length; i++)
                Console.WriteLine(input1 * int.Parse(input2) / pow(10, i) % 10);
            
            Console.WriteLine(input1 * int.Parse(input2));
            Console.ReadLine();
        }
        static int pow(int num, int pow) {  //제곱계산
            int res = 1;
            for (int i = 0; i < pow; i++)
                res *= num;
            return res;
        }
    }
}
