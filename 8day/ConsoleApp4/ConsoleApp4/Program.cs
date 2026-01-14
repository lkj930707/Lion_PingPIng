using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Character
    {
        //프로퍼티 설명
        //
        //private int Att; //은닉성 
        ////Get Set 
        //public void SetAtt(int _Att) //외부에서 인자를 받아 처넣음
        //{
        //    Att = _Att;
        //}
        //public int GetAtt()
        //{
        //    return Att; //외부로 뱉어버림
        //}

        private int att;
        //public int Att //프로퍼티 
        //{
        //    get { return att; }

        //    set { att = value; }
        //}

        // = ==== 같은거
        public int Att { get; set; } //축약

        private int maxHp = 10;
        private int maxMp = 20;
        public int MaxHP 
        { 
            get
            {
                return maxHp; 
            }
            private set 
            {
            }
        } //셋 잠굼 읽기전용

        public int MaxMP { get; private set; } = 20; //숫자가아닌 변수형태로 넣으려면
                                                     //const상수거나 문자열형태리터럴만가능
    }

    internal class Program
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Character character = new Character();
            //character.SetAtt(10);
            //Console.WriteLine("공격력 :"+character.GetAtt());
            character.Att = 1;
            Console.WriteLine(character.Att);
            Console.WriteLine(character.MaxHP);
            Console.WriteLine(character.MaxMP);

        }
    }
}
