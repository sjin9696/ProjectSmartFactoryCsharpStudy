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
            //input_TotalSecondToSecMinPrint(); //사용자로 부터 양수인 전체 초를 입력받아 분:초로 표시
            //input_StringAlphabetCountPrint();   //소문자로만입력받은 문자열에서 글자가 몇번 나왔는지 표시
            //input_StringFirstAlphabetPrint();   //입력받은 문자열의 글자가 최초로 등장하는 위치를 표시
            //starPiramid_print();    //삼각형 모양 피라미드를 만드시오
            //input_numMaxMinPrint(); //5개의 숫자를 입력받은 뒤 가장 작은 수와 가장 큰 수를 표시
            sequencePrint(); //개미수열 표시
            //aaa();
            //bbb();
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
            List<string> seasonArray = new List<string>() { "봄", "여름", "가을", "겨울" };
            int index = 0;
            Console.WriteLine("계절을 확인하고 싶은 월을 입력해주세요.(1~12)");
            int month = int.Parse(Console.ReadLine());
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
            for (int i = 1; i <= 100; i++)
            {
                sum = (i % 3 == 0) ? (sum += 0) : (sum += i);
            }
            Console.WriteLine("1~100까지 3의 배수를 제외한 합은 \"" + sum + "\" 입니다.");
            //Console.WriteLine($"1~100까지 3의 배수를 제외한 합은 \" {sum} \" 입니다.");
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
            Console.WriteLine("처리한 n분:n초는 \"" + inputTotalSecond / 60 + "분:" +
                inputTotalSecond % 60 + "초\" 입니다.");
            Console.ReadLine();
            return;
        }
        static void input_StringAlphabetCountPrint()
        {
            //입력된 알파벳 문자열(단 소문자로만 입력할 것)의 각 글자들이 
            //해당 문자열에서 몇 번씩 나왔는지 출력하시오
            Console.WriteLine("문자열을 입력받아 알파벳의 수를 출력합니다. 소문자로만 입력");
            String inputString2 = Console.ReadLine();
            List<string> tempStringList = new List<string>();
            //정렬 처리
            char[] cInput = inputString2.ToCharArray();
            Array.Sort<char>(cInput);
            string inputString = new string(cInput);

            //카운트 처리
            foreach (char item in inputString)
            {
                int count = 0;
                foreach (char alpha in inputString)
                {
                    if (item == alpha)
                        count++;
                }
                //문자열 체크 중복검사 처리
                if (!tempStringList.Contains("\'" + item + "\'는\"" + count + "\"글자 입니다"))
                {
                    tempStringList.Add("\'" + item + "\'는\"" + count + "\"글자 입니다");
                }
            }
            //tempStringList 출력
            foreach (string item in tempStringList)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
            return;
        }
        static void input_StringFirstAlphabetPrint()
        {
            //입력된 알파벳(단,소문자)에서 각각의 
            //알파벳 글자가 최초로 등장하는 위치를 적으시오
            Console.WriteLine("문자열을 입력받아 처음 등장한 알파벳의 수를 출력합니다. 소문자로만 입력");
            String inputString = Console.ReadLine();
            List<string> tempStringList = new List<string>();
            //최초등장위치 처리
            foreach (char item in inputString)
            {
                string sForm = item + "는 " + (inputString.IndexOf(item) + 1) + "번째에서 등장합니다.";
                if (!tempStringList.Contains(sForm))
                    tempStringList.Add(sForm);
            }
            //tempStringList 출력
            foreach (string item in tempStringList)
                Console.WriteLine(item);

            Console.ReadLine();
            return;
        }
        static void starPiramid_print()
        {
            Console.WriteLine("삼각형 모양 피라미드를 만듭니다. 크기를 입력하세요: ");
            int size = int.Parse(Console.ReadLine());
            //삼각형 모양 피라미드를 만드시오
            for (int line = 0; line < size; line++)
            {
                for (int blank = size - line; blank > 0; blank--)
                    Console.Write(" ");
                for (int star = 0; star <= line * 2; star++)
                    Console.Write("*");
                Console.Write("\n");
            }
            Console.ReadLine();
            return;
        }
        static void input_numMaxMinPrint()
        {
            //5개의 숫자를 입력받은 뒤 가장 작은 수와 가장 큰 수를 출력하는 프로그램을 작성하시오.
            Console.WriteLine("5개의 숫자를 입력받은 뒤 가장 작은 수와 가장 큰 수를 출력합니다.");
            //입력 처리
            int[] array = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write((i + 1) + "번째 정수를 입력하세요:");
                array[i] = int.Parse(Console.ReadLine());
            }
            //가공-출력
            Console.Write("입력한 값은 ");
            foreach (int item in array)
                Console.Write(item + " ,");
            Console.WriteLine("입니다.");
            //최대,최소 가공 처리 출력
            Console.WriteLine("입력받은 가장 작은 수는 \"" + array.Min() + "\"입니다.");
            Console.WriteLine("입력받은 가장 큰 수는 \"" + array.Max() + "\"입니다.");
            Console.ReadLine();
            return;
        }
        static void sequencePrint()
        {
            /*아래의 규칙을 따르는 수열의 20번째 숫자를 프로그램을 만들어 찾으시오.
            1, 11, 12, 1121, 122111, 112213
            첫 번째 수열: 1
            두 번째 수열: 1이 1개 = 11
            세 번째 수열: 1이 2개 = 12
            네 번째 수열 1이 1개, 2가 1개 = 1121
            다섯 번째 수열: 1이 2개, 2가 1개, 1이 1개 = 122111
            여섯 번째 수열: 1이 1개, 2가 2개 1이 3개 = 112213
            */
            string input = "1";

            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine($"{i} : {input}");
                //읽고 말하기 수열 계산
                string result = "";
                char number = input[0];
                int count = 0; //number의 개수
                for (int j = 0; j < input.Length; j++)
                {
                    //문자열과 가리키는 숫자가 같지 않다면 
                    if (number != input[j])
                    {
                        result = result + number + count;
                        number = input[j]; //입력값을 가리키는 숫자에 넣는다
                        count = 1;
                    }
                    //같다면 카운터를 올린다.
                    else
                    {
                        count++;
                    }
                }
                result = result + number + count;

                input = result;
            }

            Console.ReadLine();
            return;
        }
    }//끝 class practice01
}//끝 namespace ConsoleApp1

