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
            inch_print();   //inch-> cm
            pound_kg_print();   //파운드 -> 킬로그램
            circle_value_print(); //반지름 -> 원 둘레, 원 넓이.
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
            Console.WriteLine("원의 둘레는 "+double.Parse(input) *2* pi + " 입니다.");
            Console.WriteLine("원의 넓이는 "+ double.Parse(input) * double.Parse(input) * pi + " 입니다.");
        }
    }
}
