﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _01_Console
{
    public class Human : Character  // Human 클래스는 Character 클래스를 상속 받았다.
    {
        int mp = 100;
        int maxMp = 100;

        public Human()  // 상속받은 부모의 생성자도 같이 실행
        {            
        }

        public Human(string newName) : base(newName)
        {
<<<<<<< HEAD
            //GenerateStatus();

=======
>>>>>>> e21fd8ea4c5c289ab2fe1636c13340a5efec05fb
        }

        public override void GenerateStatus()
        {
            base.GenerateStatus();  // Character의 GenerateStatus 함수 실행
            maxMp = rand.Next() % 100;  // 추가한 변수만 추가로 처리
            mp = maxMp;
        }

        public override void TestPrintStatus()
        {
            Console.WriteLine("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
            Console.WriteLine($"┃ 이름\t:{name,10}             ┃ ");
            Console.WriteLine($"┃ HP\t:{hp,4} / {maxHP,4}               ┃ ");
            Console.WriteLine($"┃ MP\t:{mp,4} / {maxMp,4}               ┃ ");
            Console.WriteLine($"┃ 힘\t:{strenth,3}                       ┃ ");
            Console.WriteLine($"┃ 민첩\t:{dexterity,3}                       ┃ ");
            Console.WriteLine($"┃ 지능\t:{intellegence,3}                       ┃ ");
            Console.WriteLine("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");
        }

        public override void Attack(Character target)
        {
            int damage = strenth;

            //rand.NextDouble();  // 0.0 ~ 1.0
            if (rand.NextDouble() < 0.3f)   // 이 조건이 참이면 30% 안쪽으로 들어왔다.
            {
                damage *= 2;    // damage = damage * 2;
                Console.WriteLine("크리티컬 히트!");
            }

            Console.WriteLine($"{name}이 {target.Name}에게 공격을 합니다.(공격력 : {damage})");
            target.TakeDamage(damage);
        }
<<<<<<< HEAD
        
        public void Skill()
        {
        
            Console. ReadKey();

            switch ()
)           {

                case 1
                { Console.WriteLine($"{Human}이 도끼를 사용합니다."}; 

                case 2
                 { Console.WriteLine($"{Human}이 은도끼를 사용합니다"};  

                case 3
                { Console.WriteLine($"{Human}이 금도끼를 사용합니다"};
            }

        }

    
    
=======

        public void Skill(Character target)
        {
            // rand.NextDouble() : 0 ~ 1
            // rand.NextDouble() * 1.5f : 0 ~ 1.5
            // ((rand.NextDouble() * 1.5f) + 1) : 1 ~ 2.5

            int damage = (int)(((rand.NextDouble() * 1.5f) + 1) * intellegence);    // 지능을 1 ~ 2.5배 한 결과에서 소수점 제거한 수
            Console.WriteLine($"{name}이 {target.Name}에게 스킬을 사용 합니다.(공격력 : {damage})");
            target.TakeDamage(damage);
        }
>>>>>>> e21fd8ea4c5c289ab2fe1636c13340a5efec05fb
    }
}