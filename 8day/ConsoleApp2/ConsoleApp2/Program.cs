using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
   //캐릭터 클래스 정의
    class Character
    {
        // 필드 (Field): 클래스의 데이터
        private string name;
        private int level;
        private int hp;
        private int maxHP;
        private int mp;
        private int maxMP;

        public Character(string _name,int _hp,int _mp)
        {
            name = _name;
            level = 1;
            hp = _hp;
            mp = _mp;
            maxHP = 100;
            maxMP = 50;
                

        }
        public Character(string _name,int _level,int _hp,int _mp)
        {
            name = _name;
            level = _level;
            hp = _hp;
            maxHP = _level*100;
            mp = _mp;
            maxMP = _level*50;
                
        }
        public void ShowInfo()
        {
            Console.WriteLine("_______________________");
            Console.WriteLine($"이름 : {name}");
            Console.WriteLine($"레벨 : {level}");
            Console.WriteLine($"HP : {hp}/{maxHP}");
            Console.WriteLine($"MP : {mp}/{maxMP}");
            Console.WriteLine("_______________________");
        }
        public void TakeDamage(int damage)
        {
            hp -= damage;
            if (hp < 0) hp = 0;
            Console.WriteLine($"⚔️{name}이(가) {damage} 데미지를 받았습니다");
            Console.WriteLine($"    남은 HP: {hp}/{maxHP}");
        }
        public void Heal(int amount)
        {
            int cHp = hp;
            hp += amount;
            if (hp > maxHP) 
            {
                hp = maxHP;
                Console.WriteLine($"💚{name}의 HP가 {maxHP-cHp}회복 되었습니다");
                Console.WriteLine($"    현재 HP: {hp}/{maxHP}");
            }
            else
            {

                Console.WriteLine($"💚{name}의 HP가 {amount}회복 되었습니다");
                Console.WriteLine($"    현재 HP: {hp}/{maxHP}");
            }
        }
        public void SetInfo(string _name,int _level,int _hp, int _mp,int _maxHp,int _maxMp)
        {
            name= _name;
            level = _level;
            hp = _hp;
            mp = _mp;
            maxHP = _maxHp;
            maxMP = _maxMp;
            
        }
    }
    
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Character player = new Character("길동",51,50);
           // player.hp = 51;
            player.ShowInfo();
            player.TakeDamage(50);
            player.Heal(30);


            //새로운 객체 생성 해서 임의값 입력후 출력 

            Character charater = new Character("덕배",50,80);

            //charater.mp = 50;
            //charater.hp = 80;

            charater.SetInfo("칠배", 5, 50, 50, 100, 50);
            charater.ShowInfo(); // 메서드 호출출력
            charater.TakeDamage(50); //데미지 50
            charater.Heal(99); // 힐 99

        }
    }
}
