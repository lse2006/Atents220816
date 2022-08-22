using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Console
{
    public class Orc : Character
    {
        int rage = 0;
<<<<<<< HEAD
        int rageMax = 100;
        bool berserker = false;

=======
        const int MaxRage = 100;    // 상수로 설정. 시작부터 끝까지 값이 변하지 않는다.
        bool berserker = false;

        public Orc(string newName) : base(newName)
        {            
        }

        public override void GenerateStatus()
        {
            base.GenerateStatus();
            strenth = rand.Next(30) + 1;
            rage = 0;
        }

>>>>>>> e21fd8ea4c5c289ab2fe1636c13340a5efec05fb
        void BerserkerMode(bool on)
        {
            berserker = on;
            if (berserker)
            {
                strenth *= 2;
            }
            else
            {
<<<<<<< HEAD
                //strenth 
                strenth = strenth >> 1;
             }
        }

        public override void TakeDamage(int damge)
        {
            //맞을 때마다 최대 분노의 1/10 증가 + 데미지 10당 1씩 증가
            rage += (int)rageMax * 0.1f + TakeDamage * 0.1f);
            if (rage >= rageMax)
            {
                BerserkerMode(ture);
            }
            base.TakeDamage(damge);
        }
        


        //string name = enemy;
        //int hp = 50;
        //int maxHp = 50;

        //public override void Attack(Character target)
        //{
        //    int damage = strenth;

     
        //    Console.WriteLine($"{human}이 {target.enemy}에게 공격을 합니다.(공격력 : {damage})");
        //    target.TakeDamage(damage);
        //}





=======
                //strenth /= 2;
                strenth = strenth >> 1; // 절반으로 줄이기
            }
        }

        public override void TakeDamage(int damage)
        {
            // 맞을 때마다 최대 분노의 1/10 증가 + 데미지 10당 1씩 증가
            rage += (int)(MaxRage * 0.1f + damage * 0.1f);
            if(rage >= MaxRage)
            {
                BerserkerMode(true);
            }
            base.TakeDamage(damage);
        }

        public override void TestPrintStatus()
        {
            Console.WriteLine("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
            Console.WriteLine($"┃ 이름\t:\t{name}");
            Console.WriteLine($"┃ HP\t:\t{hp,4} / {maxHP,4}");
            Console.WriteLine($"┃ Rage\t:\t{rage,4} / {MaxRage,4}");
            Console.WriteLine($"┃ 힘\t:\t{strenth,2}");
            Console.WriteLine($"┃ 민첩\t:\t{dexterity,2}");
            Console.WriteLine($"┃ 지능\t:\t{intellegence,2}");
            Console.WriteLine("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");
        }
>>>>>>> e21fd8ea4c5c289ab2fe1636c13340a5efec05fb
    }
}
