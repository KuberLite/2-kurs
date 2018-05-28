using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero elf = new Hero(new ElfFactory());
            elf.Hit();
            elf.Run();

            Hero voin = new Hero(new VoinFactory());
            voin.Hit();
            voin.Run();

            Console.ReadLine();
        }

        abstract class Weapon
        {
            public abstract void Hit();
        }

        abstract class Movement
        {
            public abstract void Move();
        }

        //class arbalet
        class Crossbow : Weapon
        {
            public override void Hit()
            {
                Console.WriteLine("Shoot from the crossbow");
            }
        }

        //class sword
        class Sword : Weapon
        {
            public override void Hit()
            {
                Console.WriteLine("Beats the sword");
            }
        }

        //class flight
        class Flight : Movement
        {
            public override void Move()
            {
                Console.WriteLine("Flying");
            }
        }

        //class movement - run 
        class RunMovement : Movement
        {
            public override void Move()
            {
                Console.WriteLine("Running");
            }
        }

        //class 
        abstract class HeroFactory
        {
            public abstract Movement CreateMovement();
            public abstract Weapon CreateWeapon();
        }
        // Фабрика создания летящего героя с арбалетом
        class ElfFactory : HeroFactory
        {
            public override Movement CreateMovement()
            {
                return new Flight();
            }

            public override Weapon CreateWeapon()
            {
                return new Crossbow();
            }
        }
        // Фабрика создания бегущего героя с мечом
        class VoinFactory : HeroFactory
        {
            public override Movement CreateMovement()
            {
                return new RunMovement();
            }

            public override Weapon CreateWeapon()
            {
                return new Sword();
            }
        }
        // клиент - сам супергерой
        class Hero
        {
            private Weapon weapon;
            private Movement movement;
            public Hero(HeroFactory factory)
            {
                weapon = factory.CreateWeapon();
                movement = factory.CreateMovement();
            }
            public void Run()
            {
                movement.Move();
            }
            public void Hit()
            {
                weapon.Hit();
            }
        }
    }
}
