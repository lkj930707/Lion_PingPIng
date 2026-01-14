using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace shuterGame
{
    //미사일 클래스
    public class BULLET
    {
        public int x;
        public int y;
        public bool fire;
    }
    //블레이어 클래스
    public class Player
    {
        [DllImport("msvcrt.dll")]
        static extern int _getch(); //c언어함수임포트

        public int playerX; //플레이어 x
        public int playerY; //플레이어 y

        //껍데기생성
        public BULLET[] playerBullet = new BULLET[20]; //미사일 20개 생성후 준비된 미사일을 활용
                                                       //유니티에선 오브젝트 풀이라는 개념으로발전...
                                                       //아이템먹엇을때를위해 배열추가
        public BULLET[] itemBullet = new BULLET[20];
        public BULLET[] itemBullet2 = new BULLET[20];
        public int score = 100;
        //아이템
        public Item item = new Item();//아이템 객체 생성
        public int itemCount = 0;
        public Player() //생성자
        {
            //플레이어 좌표위치 초기화
            playerX= 0;
            playerY= 12;

            for(int i = 0; i < playerBullet.Length; i++)
            {
                playerBullet[i] = new BULLET(); //객체생성
                playerBullet[i].x = 0;
                playerBullet[i].y = 0;
                playerBullet[i].fire = false;

                itemBullet[i] = new BULLET(); //객체생성
                itemBullet[i].x = 0;
                itemBullet[i].y = 0;
                itemBullet[i].fire = false;

                itemBullet2[i] = new BULLET(); //객체생성
                itemBullet2[i].x = 0;
                itemBullet2[i].y = 0;
                itemBullet2[i].fire = false;
            }
        }
        public void GameMain()
        {
            //키를 입력하는 부분
            KeyControl();
            //플레이어를 그려줌
            PlayerDraw();
            //UI점수 
            UIScore();
            
            if(item.ItemLife = true)
            {
                //item.ItemMove();
                item.ItemDraw();
                //아이템 충돌 
                CrashItem();
            }

            
        }
        public void CrashItem()
        {
            if(playerY+1== item.ItemY)
            {
                if (playerX >= item.ItemX - 2 && playerX <= item.ItemX + 2)
                {
                    item.ItemLife = false;
                    if (itemCount < 3) 
                    {
                        itemCount++;
                    }
                }
            }
        }

        private void UIScore()
        {
            Console.SetCursorPosition(63, 0);
            Console.Write("┏━━━━━━━━━━━━━━┓");
            Console.SetCursorPosition(63, 1);
            Console.Write("┃              ┃");
            Console.SetCursorPosition(65, 1);
            Console.Write("Score : " + score);
            Console.SetCursorPosition(63, 2);
            Console.Write("┗━━━━━━━━━━━━━━┛");
        }

        public void KeyControl()
        {
            int pressKey;//정수형 변수선언 키값 받을거
            if (Console.KeyAvailable)//키가눌렸을때
            {
                pressKey = _getch(); //아스키값 왼쪽 오른쪽등등
                switch (pressKey)
                {
                    case 72: //위쪽방향 아스키코드값
                        playerY--;
                        if (playerY < 1) playerY = 1;
                    break;
                    case 75: //왼쪽
                        playerX--;
                        if (playerX < 1) playerX= 1;
                        break;
                    case 77: //우측
                        playerX++;
                        if (playerX > 75) playerX = 75;
                    break;
                    case 80: //하단방향 아스키코드값
                        playerY++;
                        if (playerY > 75) playerY = 75;
                    break;
                    case 32: //스페이스바
                        for(int i =0; i < playerBullet.Length; i++)
                        {
                            if (playerBullet[i].fire == false)//발사전상태
                            {
                                playerBullet[i].fire = true;
                                //플레이어 앞에서 발사 
                                playerBullet[i].x =playerX +5;
                                playerBullet[i].y =playerY +1;
                                //한발씩 쏘겠다
                                break;
                            }
                        }

                        for (int i = 0; i < itemBullet.Length; i++)
                        {
                            if (itemBullet[i].fire == false)//발사전상태
                            {
                                itemBullet[i].fire = true;
                                //플레이어 앞에서 발사 
                                itemBullet[i].x = playerX + 5;
                                itemBullet[i].y = playerY + 1;
                                //한발씩 쏘겠다
                                break;
                            }
                        }

                        for (int i = 0; i < itemBullet2.Length; i++)
                        {
                            if (itemBullet2[i].fire == false)//발사전상태
                            {
                                itemBullet2[i].fire = true;
                                //플레이어 앞에서 발사 
                                itemBullet2[i].x = playerX + 5;
                                itemBullet2[i].y = playerY + 1;
                                //한발씩 쏘겠다
                                break;
                            }
                        }
                        break;
                }
            }
        }

        //미사일 그리기
        public void BulletDraw()
        {
            string bullet = "->"; //미사일의 모습
            //현재 20개중 살아있는 애 찾기
            for(int i = 0; i < playerBullet.Length; i++)
            {
                if (playerBullet[i].fire == true)
                {
                    //중간위치를 보정하기위해 x좌표 -1 
                    Console.SetCursorPosition(playerBullet[i].x - 1, playerBullet[i].y);
                    //총알 출력
                    Console.Write(bullet);
                    playerBullet[i].x++;
                    if (playerBullet[i].x > 77)
                    {
                        playerBullet[i].fire = false; //미사일 다시준비
                    }
                }
            }

        }
        public void BulletDraw2()
        {
            string bullet = "->"; //미사일의 모습
            //현재 20개중 살아있는 애 찾기
            for (int i = 0; i < itemBullet2.Length; i++)
            {
                if (itemBullet2[i].fire == true)
                {
                    //중간위치를 보정하기위해 x좌표 -1 
                    Console.SetCursorPosition(itemBullet2[i].x - 1, itemBullet2[i].y);
                    //총알 출력
                    Console.Write(bullet);
                    itemBullet2[i].x++;
                    if (itemBullet2[i].x > 77)
                    {
                        itemBullet2[i].fire = false; //미사일 다시준비
                    }
                }
            }

        }
        public void BulletDraw3()
        {
            string bullet = "->"; //미사일의 모습
            //현재 20개중 살아있는 애 찾기
            for (int i = 0; i < itemBullet.Length; i++)
            {
                if (itemBullet[i].fire == true)
                {
                    //중간위치를 보정하기위해 x좌표 -1 
                    Console.SetCursorPosition(itemBullet[i].x - 1, itemBullet[i].y);
                    //총알 출력
                    Console.Write(bullet);
                    itemBullet[i].x++;
                    if (itemBullet[i].x > 77)
                    {
                        itemBullet[i].fire = false; //미사일 다시준비
                    }
                }
            }

        }
        public void PlayerDraw()
        {
            string[] player = new string[]
            {
                "->",
                ">>>",
                "->"
            };
            for(int i=0; i<player.Length; i++)
            {
                //콘솔좌표 설정 플레이어 x 플레이어 y
                Console.SetCursorPosition(playerX, playerY + i);
                //문자열배열출력
                Console.WriteLine(player[i]);
            }
        }
        //충돌처리 적구현후 함수구현 
        public void ClashEnemyAndBullet(Enemy enemy)
        {
            for (int i = 0; i < playerBullet.Length; i++)
            {
                //미사일 산거
                if (playerBullet[i].fire == true)
                {
                    if (playerBullet[i].y == enemy.enemyY) //미사일과 y값이 같을때
                    {
                        if (playerBullet[i].x >= (enemy.enemyX - 1) && playerBullet[i].x <=(enemy.enemyX + 1))
                        {
                            //충돌 유격▲

                            //아이템
                            item.ItemLife = true;
                            item.ItemX = enemy.enemyX;
                            item.ItemY = enemy.enemyY;
                            //충돌▼
                            Random random = new Random();
                            enemy.enemyX = 75;
                            enemy.enemyY = random.Next(2, 22);

                            playerBullet[i].fire = false; //미사일 준비상태로

                            //점수
                            score += 100;

                        }
                    }
                }
            }

        }
    }
    //적클래스
    public class Enemy
    {
        public int enemyX; //x좌표
        public int enemyY; //y좌표
        public Enemy()
        {
            enemyX = 77;
            enemyY = 12;
        }
        public void EnemyDraw()
        {
            //적기 그리기 
            string enemy = "<-0->";
            Console.SetCursorPosition(enemyX, enemyY);
            Console.Write(enemy);
        }
        public void EnemyMove()
        {
            Random random = new Random(); //랜덤함수 객체생성
            enemyX--;
            if (enemyX < 2) //좌측으로 넘어가면 새로 좌표잡기
            {
                enemyX = 75;
                enemyY = random.Next(2, 22); //2~21
            }

        }
        
    }
    //아이템 클래스
    public class Item
    {
        public string ItemName;
        public string ItemSprite;
        public int ItemX = 0;
        public int ItemY = 0;
        public bool ItemLife = false;

        public void ItemDraw()
        {
            Console.SetCursorPosition(ItemX, ItemY);
            ItemSprite = "★item★";
            Console.Write(ItemSprite);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25); //스크롤방지

            //플레이어 생성 
            Player p = new Player(); //플레이어 객체
            Enemy e = new Enemy(); //적 객체

            //콘솔 속도 frame 게임 60fps 

            int dwTime = Environment.TickCount; // 1/1000 초가 흐른다

            while (true) //무한반복
            {
                // 0.05초 지연 
                if(dwTime +50< Environment.TickCount)
                {
                    //현재 시간 셋팅
                    dwTime = Environment.TickCount;
                    Console.Clear();

                    //플레이어 
                    p.GameMain();
                    //총알
                    p.BulletDraw();
                    //적이동
                    e.EnemyMove();
                    e.EnemyDraw();

                    //충돌처리
                    p.ClashEnemyAndBullet(e);
                    
                }
            }


        }
    }
}
