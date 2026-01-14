using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //배열 
            //int[] num = { 1, 2, 3, 4, 5 };
            //num[0] = 2;
            //num[1] = 2;

            //for (int i=0;i<5; i++)
            //{
            //    num[i] = i + 1;
            //    Console.WriteLine($"num{i} = {num[i]}");
            //}

            //방법1
            //int cal = 5;
            //int[] scores = new int[cal]; // 몇개만들지 > 5개 만든값은 변경되지않음

            ////방법2 초기값과 함께 선언
            //int[] numbers = new int[] { 10, 20, 30, 40, 50 };

            ////방법3 간단한 초기화
            //int[] values = { 1, 2, 3,4, 5 };
            ////방법4 
            //scores[0] = 1;
            //scores[1] = 2;
            //scores[2] = 3;
            //scores[3] = 4;
            //scores[4] = 5;
            //// 
            //for (int i =0; i<scores.Length; i++)
            //{
            //    Console.WriteLine(scores[i]);
            //}

            //인벤토리 시스템 (최대 5개)
            //string[] inven= new string[5];

            //Console.WriteLine("===인벤토리===");
            //for(int i = 0; i < inven.Length; i++)
            //{
            //    switch (i)
            //    {
            //        case 0:inven[i] = "회복 포션"; break;
            //        case 1:inven[i] = "마나 포션"; break;
            //        case 2:inven[i] = "강철 검";  break;
            //        case 3:inven[i] = "가죽 갑옷"; break;
            //        case 4:inven[i] = "마법 반지"; break;
            //    }
            //    Console.WriteLine(inven[i]);
            //}

            // 입력을 받아서 아이템 추가 
            //string[] inv = new string[5];


            //for (int i = 0; i < inv.Length; i++)
            //{
            //    Console.WriteLine($"얻고싶은 아이템을 입력하세요 : {i + 1} 번째 인벤토리");
            //    inv[i] = Console.ReadLine();
            //    Console.WriteLine($"인벤토리{i+1} : {inv[i]}" );
            //}

            ////특정 아이템 사용 
            //Console.WriteLine($"{inv[0]}를(을) 사용했습니다 !");
            //inv[0] = "(비어있음)";
            //for(int i = 0; i < inv.Length; i++)
            //{
            //    Console.WriteLine($"[{i + 1}] {inv[i]}");
            //}

            //string[] status = new string[5];
            //status[0] = "HP : 100";
            //status[1] = "MP : 50";
            //status[2] = "공격력 : 80";
            //status[3] = "방어력 : 60";
            //status[4] = "민첩 : 45";
            //Console.WriteLine("===캐릭터 스탯===");
            //for(int i = 0; i < status.Length; i++)
            //{
            //    Console.WriteLine(status[i]);
            //}

            //플레이어 스탯 
            //Console.WriteLine("===캐릭터 스탯===");
            //int[] stat = {100,50,80,60,45 };
            //string[] stat2 = {"HP :","MP :","공격력 :","방어력 :","민첩 :" };
            //for (int i = 0; i < stat.Length; i++)
            //{
            //    Console.WriteLine(stat2[i] + stat[i]);
            //}

            //일퀘 진행도 
            //Console.WriteLine("===일일 퀘스트 진행도===");
            //string[] monster = { "고블린", "오크", "슬라임", "드래곤", "좀비" };
            //int[] num = { 5, 0, 8, 2, 7 };
            //const int MAXNUM = 5;
            //for (int i = 0; i < monster.Length; i++)
            //{
            //    if (num[i] >= MAXNUM)
            //    {
            //        Console.WriteLine($"{monster[i]}:{num[i]}/{MAXNUM} ✅  완료");
            //    }else if (num[i] == 0)
            //    {
            //        Console.WriteLine($"{monster[i]}:{num[i]}/{MAXNUM} 🙂  시작가능");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{monster[i]}:{num[i]}/{MAXNUM} ⏳  진행중");
            //    }
            //}
            
            int[] score = { 85, 92, 78, 95, 88 };
            //배열길이
            Console.WriteLine("총 인원 수 : " + score.Length);
            //배열순회
            Console.WriteLine("===개별 점수===");
            for (int i = 0; i < score.Length; i++)
            {
                Console.WriteLine($"플레이어{i} : {score[i]}");
            }
            //합계 계산
            int sum = 0;
            for (int i = 0; i < score.Length; i++)
            {
                sum += score[i];
            }
            Console.WriteLine($"총점 : {sum}");
            Console.WriteLine($"평균 : {sum / (float)score.Length} 점");


            int max = score[0];
            //최고점 찾기
            for(int i = 0; i< score.Length; i++)
            {
                if (score[i] > max)
                {
                    max = score[i];
                   
                }
            }
            Console.WriteLine($"최고점 : {max}");
            //최저점 찾기
            int min = score[0];
            
            for(int i =0;i<score.Length; i++)
            {
                if (score[i] < min)
                {
                    min = score[i];
                }
            }
            Console.WriteLine($"최저점: "+min);

            //Array 클래스 매서드 이용
            Console.WriteLine("===Array 매서드");

            //for (int i = 0; i < score.Length; i++)
            //{
            //    Console.WriteLine(setScore[i]);
            //}
            ////역순 
            //Console.WriteLine("역순");
            //Array.Reverse(setScore);
            //for (int i = 0; i < score.Length; i++)
            //{
            //    Console.WriteLine(setScore[i]);
            //}
            ///////////////////////
            ///

            //포이치문
            //int[] setScore = (int[])score.Clone();
            ////Array.Sort(setScore);
            //Array.Reverse(setScore);//역순
            //foreach (int scored in setScore)
            //{
            //    Console.WriteLine(score);
            //}
            //Console.WriteLine("짠");
            //Array.Sort(setScore);//정순
            //foreach (int scored in setScore)
            //{
            //    Console.WriteLine(score);
            //} //어딘가 잘못됌 모르겠음 


        }
    }
}
