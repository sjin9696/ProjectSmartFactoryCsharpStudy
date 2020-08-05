using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class practice01
    {
        static void Main(string[] args)
        {
            //chineseZodiac();    //입력한 년도에서 띠를 표시
            //monthToSeasonPrint();   //입력한 월에 따른 계절 표시
            //todayChineseZodiacPrint();  //현재년도가 무슨띠 인지 표시
            //monthToSeasonPrint(DateTime.Now.Month); //현재 월이 무슨 계절인지 표시
            //sum_1_100_Except3_Print();  //1~100까지 3의 배수를 제외한 합을 표시
            input_TotalSecondToSecMinPrint(); //사용자로 부터 양수인 전체 초를 입력받아 분:초로 표시
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
        static void monthToSeasonPrint()
        {
            //스위치문 안쓰고 출력 방법 찾아 보기.
            List<string> seasonArray = new List<string>() { "봄", "여름", "가을", "겨울"};
            int index = 0;
            Console.WriteLine("계절을 확인하고 싶은 월을 입력해주세요.(1~12)");
            int month = int.Parse(Console.ReadLine());
            if ((1 <= month) && (month <= 12))
            {
                switch(month)
                {
                    case 1:
                    case 2:
                    case 12:
                        index = 3;
                        break;
                    case 3:
                    case 4:
                    case 5:
                        index = 0;
                        break;
                    case 6:
                    case 7:
                    case 8:
                        index = 1;
                        break;
                    case 9:
                    case 10:
                    case 11:
                        index = 2;
                        break;
                    default:
                        break;
                }//switch끝
            }//if 끝
            else
            {
                Console.WriteLine("입력 범위를 벗어 났습니다.");
            }
            Console.WriteLine("입력한 월은 " + month + "입니다");
            Console.WriteLine("입력한 월의 계절은 \"" + seasonArray[index] + "\"입니다");
            Console.ReadLine();
            return;
        }
        static void todayChineseZodiacPrint()
        {
            List<string> chineseZodiacArray = new List<string>() { "쥐띠", "닭띠", "개띠", "돼지띠", "쥐띠", "소띠", "범띠", "토끼띠", "용띠", "뱀띠", "말띠", "양띠" };

            Console.WriteLine("태어난 년도를 입력해주세요.");
            //int year_birth = int.Parse(Console.ReadLine());
            DateTime dt_year = DateTime.Now;
            int year_birth = dt_year.Year;

            Console.WriteLine("입력한 태어난 년도는 " + year_birth + "입니다");
            Console.WriteLine("입력한 태어난 년도의 띠는 \"" + chineseZodiacArray[(year_birth % 12)] + "\"입니다");
            Console.ReadLine();
            return;
        }
        static void monthToSeasonPrint(int input_month)
        {
            //스위치문 안쓰고 출력 방법 찾아 보기.
            List<string> seasonArray = new List<string>() { "봄", "여름", "가을", "겨울" };
            int index = 0;
            Console.WriteLine("계절을 확인하고 싶은 월을 입력해주세요.(1~12)");
            //int month = int.Parse(Console.ReadLine());
            int month = input_month;
            if ((1 <= month) && (month <= 12))
            {
                switch (month)
                {
                    case 1:
                    case 2:
                    case 12:
                        index = 3;
                        break;
                    case 3:
                    case 4:
                    case 5:
                        index = 0;
                        break;
                    case 6:
                    case 7:
                    case 8:
                        index = 1;
                        break;
                    case 9:
                    case 10:
                    case 11:
                        index = 2;
                        break;
                    default:
                        break;
                }//switch끝
            }//if 끝
            else
            {
                Console.WriteLine("입력 범위를 벗어 났습니다.");
            }
            Console.WriteLine("입력한 월은 " + month + "입니다");
            Console.WriteLine("입력한 월의 계절은 \"" + seasonArray[index] + "\"월 입니다");
            Console.ReadLine();
            return;
        }
        static void sum_1_100_Except3_Print()
        {
            //1~100까지 3의 배수를 제외한 합을 구하는 함수를 작성하세요.
            int sum = 0;
            for(int i=1;i<=100;i++)
            {
                sum = (i % 3 == 0) ? (sum += 0) : (sum += i);
            }
            Console.WriteLine("1~100까지 3의 배수를 제외한 합은 \"" + sum + "\" 입니다.");
            Console.ReadLine();
            return;
        }
        static void input_TotalSecondToSecMinPrint()
        {
            //임의의 양수인 전체 "초" 시간을 사용자로부터 입력 받아 이를 "분"과 "초"로 
            //변환하는 프로그램을 작성하세요
            Console.WriteLine("분:초로 보고 싶은 전체 초 값을 입력하세요.(양의정수)");
            int inputTotalSecond = int.Parse(Console.ReadLine());
            
            Console.WriteLine("입력한 전체 초는 \"" + inputTotalSecond + "\"초 입니다.");
            Console.WriteLine("처리한 n분:n초는 \"" + inputTotalSecond / 60 + "분:"+
                inputTotalSecond % 60 + "초\" 입니다.");
            Console.ReadLine();
            return;
        }
    }
}
