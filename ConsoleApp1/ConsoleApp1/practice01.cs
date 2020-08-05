using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class practice01
    {
        static void Main(string[] args)
        {
            chineseZodiac();    //입력한 년도에서 띠를 표시
            return;
        }
        static void chineseZodiac()
        {
            List<string> chineseZodiacArray = new List<string>() { "쥐띠", "닭띠", "개띠", "돼지띠", "쥐띠", "소띠", "범띠", "토끼띠", "용띠", "뱀띠", "말띠", "양띠" };

            Console.WriteLine("태어난 년도를 입력해주세요.");
            int year_birth = int.Parse(Console.ReadLine());
           
            Console.WriteLine("입력한 태어난 년도는 " + year_birth + "입니다");
            Console.WriteLine("입력한 태어난 년도의 띠는 \"" + chineseZodiacArray[(year_birth % 12)] + "\"입니다");
            Console.ReadLine();
            return;
        }
    }
}
