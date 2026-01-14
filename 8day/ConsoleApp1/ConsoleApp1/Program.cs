using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //클래스 정의 
    class Character
    {
        //public 다른 곳에서 사용가능하게 한다.
        //private 클래스 나자신 내부에서만 사용하게 한다
        //protected 같은 클래스와 상속받은 클래스에서 접근
        //internal //같은 어셈블리 내에서만 접근

        public string name; 
        public int level;   
        public int hp;
        public int maxHp;
        public int mp;
        public int maxMp;
        //기본 생성자 
        public Character() //리턴 타입을 적지않고 자기 클래스 이름으로 적음
        {//초기화할때 많이사용 생성자!
            name = "김덕배";
            level = 1;
            hp = 100;
            maxHp = 150;
            mp = 80;
            maxMp = 100;

        }

        //인자 있는생성자
        public Character(string _name,int _level,int _hp,int _maxHp,int _mp,int _maxMp)
        {
            name = _name;
            level = _level;
            hp = _hp;
            maxHp = _maxHp;
            mp = _maxMp;
            maxMp = _maxMp;

        }
        //함수를 모아서 사용
        public void CChar() //함수는 대부분 퍼블릭으로 열어둠
        {
            Console.WriteLine("이름: " + name);
            Console.WriteLine("레벨: " + level);
            Console.WriteLine($"체력: {hp}/{maxHp}");
            Console.WriteLine($"마력: {mp}/{maxMp}");
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Character car = new Character(); //생성자 호출
            car.name = "김출배";
            //car.level = 1;
            //car.hp = 100;
            //car.maxHp = 150;
            //car.mp = 80;
            //car.maxMp = 100;

            car.CChar();
            //Console.WriteLine("이름: "+ car.name);
            //Console.WriteLine("레벨: "+ car.level);
            //Console.WriteLine($"체력: {car.hp}/{car.maxHp}");
            //Console.WriteLine($"마력: {car.mp}/{car.maxMp}");

            //Character car2 = new Character();

            //car2.name = "김덕배";
            //car2.level = 1;
            //car2.hp = 100;
            //car2.maxHp = 150;
            //car2.mp = 80;
            //car2.maxMp = 100;

            //Console.WriteLine("이름: " + car2.name);
            //Console.WriteLine("레벨: " + car2.level);
            //Console.WriteLine($"체력: {car2.hp}/{car2.maxHp}");
            //Console.WriteLine($"마력: {car2.mp}/{car2.maxMp}");

            Character car3 = new Character("덕배",33,21,100,50,100);
            car3.CChar();

            

        }
    }
}
