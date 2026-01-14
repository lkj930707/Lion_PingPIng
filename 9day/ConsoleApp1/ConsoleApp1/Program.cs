using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //클래스끼리 통신
    class Player
    {
        private int att;
        private int hp;

        public void SetHp(int hp)
        {
            this.hp = hp;
        }
        public int GetHp()
        {
            return this.hp;
        }
        public void SetAtt(int att)
        {
            this.att = att;
        }
        public int GetAtt()
        {
            return (this.att); 
        }

        public void Render()
        {
            Console.WriteLine("플레이어");
            Console.WriteLine($"체력 : {hp}");
            Console.WriteLine($"공격력 : {att}");
        }

    }
    class Monster
    {
        private int att;
        private int hp;

        public void SetHp(int hp)
        {
            this.hp = hp;
        }
        public int GetHp()
        {
            return this.hp;
        }
        public void SetAtt(int att)
        {
            this.att = att;
        }
        public int GetAtt()
        {
            return (this.att);
        }
        public void Render()
        {
            Console.WriteLine("몬스터");
            Console.WriteLine($"체력 : {hp}");
            Console.WriteLine($"공격력 : {att}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //퍼블릭일때
            ////플레이어 객체
            //Player p = new Player();
            //p.att = 10;
            //p.hp = 100;
            //p.Render();
            ////몬스터 객체
            //Monster m = new Monster();
            //m.att = 5;
            //m.hp = 100;
            //m.Render();

            //m.hp = m.hp - p.att; //몬스터 체력에 체력 -플레이어공격력을 뺀값을 대입
            //p.hp = p.hp - m.att;
            //m.Render();
            //p.Render();

            //클래스내부가프라이베잇일때!

            //플레이어로 몬스터 때리기 
            Monster m = new Monster();
            Player p = new Player();

            p.SetAtt(10);
            p.SetHp(100);
            p.Render();

            m.SetAtt(5);
            m.SetHp(100);

            m.SetHp(m.GetHp() - p.GetAtt()); //몬스터의 hp에 대입 = m객체 의hp 적출-p객체 공격력적출
            p.SetHp(p.GetHp() - m.GetAtt());  //역

            
            


        }
    }
}
