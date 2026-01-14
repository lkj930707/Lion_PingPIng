using ConsoleApp9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class RpgCharacter
    {
        private string name;
        private string job;
        private int level;
        private int hp;
        private int maxHP;
        private int mp;
        private int maxMP;
        private int attack;
        private int defense;
        private int exp;
        private int gold;
        private int loserPoint;
        int dd;

        public RpgCharacter(string name,string job)
        {
            this.name = name;
            this.job = job;
            level = 1;
            exp = 0;
            gold = 0;
            loserPoint = 0;

            if(job == "전사")
            {
                maxHP = 1000;
                maxMP = 30;
                attack = 50;
                defense = 100;

            }else if (job =="마법사")
            {
                maxHP = 300;
                maxMP = 200;
                attack = 100;
                defense = 10;

            }
            else if(job == "궁수")
            {
                maxHP = 500;
                maxMP = 50;
                attack = 70;
                defense = 30;

            }
            hp = maxHP;
            mp = maxMP;
            Console.WriteLine($"{this.name}({this.job}) 캐릭터 생성!");
        }
        public void Status()
        {
            Console.WriteLine($"=={name}({job}) 능력치 ==");
            Console.WriteLine($"HP: {hp} /{maxHP}");
            Console.WriteLine($"MP: {mp} /{maxMP}");
            Console.WriteLine($"공격력: {attack}");
            Console.WriteLine($"방어력: {defense}");
        }
        public bool IsAlive()
        {
            return (hp > 0);
        }

        public int AttackTarget(RpgCharacter target)
        {
            Random rand = new Random();
            bool isCri = rand.Next(1, 101) <= 15; //15퍼센트확률 크리
            int damage = this.attack -(target.defense/3);
            if (damage < 1) damage = 1; // 데미지가 아무리작아도1은들어가게 

            int randomDamaged = rand.Next(-5, 0);
            damage = damage * (100 + randomDamaged) / 100; //랜덤데미지 95% ~100%

            if (isCri)
            {
                damage = (int)(damage * 1.3);
                Console.WriteLine($"{this.name}의 공격 크리티컬!");
            }
            else
            {
                Console.WriteLine($"{this.name}의 공격");
            }
            target.Damage(damage);
            return damage;
        }
        public bool Skill(RpgCharacter target,int manaCost)
        {
            Random random = new Random();
            
            bool isMagicCri = random.Next(1, 101) <= 20;
            if(this.mp < manaCost)
            {
                Console.WriteLine($"{this.name}의 마나가 부족합니다!");
                return false;
            }
            mp -= manaCost;
            int skillDamage = this.attack * 2;
            if(this.job == "전사")
            {
                Console.WriteLine($"{this.name}의 '집요하게 약점만 연속찌르기'발동");
                skillDamage = this.attack * 2;

            }
            else if(this.job == "마법사")
            {
                if (isMagicCri)
                {
                    Console.WriteLine($"{this.name}의 '둠'발동");
                    skillDamage = (int)this.attack * 20;
                }
                else
                {
                    Console.WriteLine($"{this.name}의 '매직 미사일'발동");
                    skillDamage = (int)this.attack * 5;
                }
            }
            else if(this.job =="궁수")
            {
                Console.WriteLine($"{this.name}의 '가이드 애로우'발동");
                skillDamage = (int)this.attack * 2;
            }
            Console.WriteLine($"마나소모 :{manaCost} ");
            target.Damage(skillDamage);
            return true;
        }
        private void Damage(int damage) //피해받기 and 사망처리
        {
            hp -= damage;
            if (hp < 0) hp = 0;
            Console.WriteLine($"{this.name}에게 ({damage}) 피해!");
            Console.WriteLine($"남은 HP : {this.hp} /{this.maxHP} 피해!");
            if(hp == 0)
            {
                Console.WriteLine($"{name}이(가) 쓰러졌습니다!");
               
            }
        }
        public void Heal(int amount) //회복
        {
            hp += amount;
            if (this.hp > this.maxHP) hp = maxHP;
                Console.WriteLine($"💚{this.name}의 HP회복: +{amount}");
                Console.WriteLine($"    현재 HP: ({hp}/{maxHP})");
        }
        public void Restore(int amount) //마나리젠
        {
            mp += amount;
            if (mp > maxMP) mp = maxMP;
            Console.WriteLine($"💙 {name}의 MP회복 : +{amount}");
            Console.WriteLine($"    현재 MP : +({mp}/{maxMP})");
        }
        public void Exp(int amount)
        {
            exp += amount;
            Console.WriteLine($"경험치 +{amount} (현재: {exp}/100)");
            while (exp >= 100)
            {
                LevelUp();
                exp -= 100;
            }
        }
        private void LevelUp()
        {
            level++;
            maxHP += 20;
            maxMP += 20;
            attack += 5;
            defense += 5;
            hp = maxHP;
            mp = maxMP; //체마 회복

            Console.WriteLine($"레벨 업 {name}이(가) {level}이 되었습니다");
            Console.WriteLine($"    HP+20 | MP+20 |공격력 +5 |방어력 +5");
        }
        public void Gold(int amount)
        {
            gold += amount;
            Console.WriteLine($"💰 골드 +{amount} (현재:{gold} G)");
        }
    }
        
    
}
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("╔═══════════════════════════════════════════╗");
            Console.WriteLine("║          RPG 캐릭터 시스템                ║");
            Console.WriteLine("╚═══════════════════════════════════════════╝\n");


        //캐릭터생성
        RpgCharacter player = new RpgCharacter("전붕", "전사");
        RpgCharacter npc = new RpgCharacter("토끼공듀", "마법사");

        Console.WriteLine();
        //초기스텟 확인
        player.Status();
        npc.Status();
        Console.WriteLine("\n━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");
        Console.WriteLine("              ⚔️ 전투 시작! ⚔️");
        Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━\n");

        int turn = 1;
        Console.CursorVisible = false;
        while (player.IsAlive() && npc.IsAlive())
        {
            Console.WriteLine($"[ 턴 {turn} ]");
            player.Status();
            npc.Status();
            Console.WriteLine("전투 :(Enter) 도망가기:(ESC)");
            
            ConsoleKeyInfo key = Console.ReadKey();
            bool isFight = false;
            key = Console.ReadKey();
            switch (key.Key)
            {
                case ConsoleKey.Enter:
                    isFight = true;
                    Console.Clear();
                    break;
                case ConsoleKey.Escape:
                    isFight = false;
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("전투 :(Enter) 도망가기:(ESC)");
                    continue;
            }
            
            if (isFight) //맞짱뜸
            {
                
                Console.Clear();
                Console.WriteLine("==전투 시작!==");
                Console.WriteLine($"{turn} 번째 턴");
                player.Status();
                Console.WriteLine("=========================");
                npc.Status();
                Console.WriteLine($"Q: 공격 W: 마법 E:회복 ESC:도망");
                key = Console.ReadKey();
                Random random = new Random();
                int enemy = random.Next( 1, 2 );
                switch (key.Key)
                {
                    case ConsoleKey.Q: //공격
                        // player.dama
                        player.AttackTarget(npc);
                        break;
                    case ConsoleKey.W: //마법
                        player.Skill(npc, 100);//스킬사용 타깃 npc 마나 100소모
                        break;
                    case ConsoleKey.E: //힐
                        player.Heal(100); //힐 회복량 
                        break;
                    case ConsoleKey.Escape: //도망
                        turn = 0;
                        break;
                    default:
                        Console.WriteLine("Q: 공격 W: 마법 E:회복 ESC:도망");
                        continue;
                }
                if (enemy == 1)
                {
                    npc.AttackTarget(player);
                }
                else if (enemy == 2)
                {
                    npc.Skill(player, 150);
                }
                turn++;
                //플레이어 선공
                //힐 or 마법
                //데미지 계산
                //마나회복타임




                //엔피시 후공
                //힐 or 마법  npc는 랜덤연산
                //데미지 계산
                //마나회복


            }
            else //도망침 상대 교체  돈 경험치X 찌질함+1
            {
                turn = 0;

            }
            if (!npc.IsAlive())
            {
                break;
            }
            
        }
        if (player.IsAlive())
        {
            Console.WriteLine("승리");
            player.Exp(80);
            player.Gold(100);
            Console.WriteLine();
            player.Status();
        }
        else
        {
            Console.WriteLine("패배했구나 이 루저자식");
            
        }


    }
    }


