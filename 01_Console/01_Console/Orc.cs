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
        int rageMax = 100;
        bool berserker = false;

        void BerserkerMode(bool on)
        {
            berserker = on;
            if (berserker)
            {
                strenth *= 2;
            }
            else
            {
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





    }
}
