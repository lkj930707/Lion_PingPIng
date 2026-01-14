using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApp3
{
    public class Monster
    {
        public string name;
        public int level;
        public int hp;
        public int attack;
        public int defense;
        public int expReward;
        public Monster() 
        {
            name = "고블린";
            level = 1;
            hp = 100;
            attack = 20;
            defense = 10;
            expReward = 100;
                
        }
        public Monster(string _name, int _level)
        {
            name = _name;
            level = _level;
            hp +=  _level*100;
            attack +=  _level * 5;
            defense +=  _level *10 ;
            expReward = expReward * _level;

        }
        public void MonsterInfo()
        {
            Console.WriteLine($"몬스터 : {name}");
            Console.WriteLine($"레벨 : {level}");
            Console.WriteLine($"체력 : {hp}");
            Console.WriteLine($"공격력 :{attack}");
            Console.WriteLine($"방어력 :{defense}");
            Console.WriteLine($"경험치 :{expReward}");
        }
        public void SetInfo(string _name,int _level)
        {
            name = _name;
            level = _level;
            hp += _level * 100;
            attack += _level * 5;
            defense += _level * 10;
            expReward = expReward * _level;

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //기본생성자를 활용 해 객체생성 및 출력
            Monster orc = new Monster();
            orc.SetInfo("오크",5);
            orc.MonsterInfo();
            //매개변수 있는 생성자 사용 고블린 5생성
            //스텟 
            Monster goblin = new Monster("고블린",5);
            goblin.MonsterInfo();

            Console.WriteLine("===필드 몬스터===");
            Monster[] monsters = new Monster[3]; //배열만 만든거
            monsters[0] = new Monster("늑대", 3); //배열당 새로 객체 생성해줘야함
            monsters[1] = new Monster("오크", 5); //배열당 새로 객체 생성해줘야함
            monsters[2] = new Monster("트롤", 10); //배열당 새로 객체 생성해줘야함

            for(int i = 0; i<monsters.Length; i++)
            {
                monsters[i].MonsterInfo();
                Console.WriteLine();
            }

        }
    }
}
