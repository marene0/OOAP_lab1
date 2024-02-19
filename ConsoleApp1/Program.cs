using System;

namespace ConsoleApp1
{
    abstract class Personage
    {
        string description = "Unknown Personage";

        public string Description { set { description = value; } }

        public virtual string GetDescription()
        {
            return description;
        }

        public abstract double Power();

        public override string ToString()
        {
            return GetDescription() + ": " + Power();
        }

        public abstract bool IsStrongerThan(Personage other);

        public abstract bool CanWinInFiveHits(Personage other);
    }

    class Human : Personage
    {
        public Human()
        {
            Description = "Human";
        }
        public override double Power()
        {
            return .10;
        }

        public override bool IsStrongerThan(Personage other)
        {
            return Power() > other.Power();
        }

        public override bool CanWinInFiveHits(Personage other)
        {
            return Power() * 5 > other.Power();
        }
    }
    class Fairy : Personage
    {
        public Fairy()
        {
            Description = "Fairy";
        }
        public override double Power()
        {
            return .20;
        }

        public override bool IsStrongerThan(Personage other)
        {
            return Power() > other.Power();
        }

        public override bool CanWinInFiveHits(Personage other)
        {
            return Power() * 5 > other.Power();
        }
    }
    class JoJo : Personage
    {
        public JoJo()
        {
            Description = "JoJo";
        }
        public override double Power()
        {
            return 1.10;
        }

        public override bool IsStrongerThan(Personage other)
        {
            return Power() > other.Power();
        }

        public override bool CanWinInFiveHits(Personage other)
        {
            return Power() * 5 > other.Power();
        }
    }
    class PatronDog : Personage
    {
        public PatronDog()
        {
            Description = "Patron dog";
        }
        public override double Power()
        {
            return 2.10;
        }

        public override bool IsStrongerThan(Personage other)
        {
            return Power() > other.Power();
        }

        public override bool CanWinInFiveHits(Personage other)
        {
            return Power() * 5 > other.Power();
        }
    }


    abstract class WeaponDecorator : Personage
    {
        public Personage personage;
        public abstract override String GetDescription();
        public abstract override double Power();
        public override string ToString()
        {
            return GetDescription() + ":" + Power();
        }

        public override bool IsStrongerThan(Personage other)
        {
            return Power() > other.Power();
        }

        public override bool CanWinInFiveHits(Personage other)
        {
            return Power() * 5 > other.Power();
        }
    }


    class Ax : WeaponDecorator
    {
        public Ax(Personage personage)
        {
            this.personage = personage;
        }
        public override string GetDescription()
        {
            return personage.GetDescription() + ",Ax";
        }
        public override double Power()
        {
            return (personage.Power() + 0.40);
        }
    }
    class Spell : WeaponDecorator
    {
        public Spell(Personage personage)
        {
            this.personage = personage;
        }
        public override string GetDescription()
        {
            return personage.GetDescription() + ",Spell";
        }
        public override double Power()
        {
            return (personage.Power() + 0.60);
        }
    }
    class F16 : WeaponDecorator
    {
        public F16(Personage personage)
        {
            this.personage = personage;
        }
        public override string GetDescription()
        {
            return personage.GetDescription() + ",F16";
        }
        public override double Power()
        {
            return (personage.Power() + 1.50);
        }
    }
    class Stick : WeaponDecorator
    {
        public Stick(Personage personage)
        {
            this.personage = personage;
        }
        public override string GetDescription()
        {
            return personage.GetDescription() + ",Stick";
        }
        public override double Power()
        {
            return (personage.Power() + 0.10);
        }
    }

    abstract class ArmorDecorator : Personage
    {
        public Personage personage;
        public abstract override String GetDescription();
        public abstract override double Power();
        public override string ToString()
        {
            return GetDescription() + ":" + Power();
        }
    }


    class MetalArmor : ArmorDecorator
    {
        public MetalArmor(Personage personage)
        {
            this.personage = personage;
        }
        public override string GetDescription()
        {
            return personage.GetDescription() + ", Metal armor";
        }
        public override double Power()
        {
            return (personage.Power() + 0.50);
        }
        public override bool IsStrongerThan(Personage other)
        {
            return Power() > other.Power();
        }
        public override bool CanWinInFiveHits(Personage other)
        {
            return Power() * 5 > other.Power();
        }
        public override string ToString()
        {
            return GetDescription() + ":" + Power();
        }
    }


    class FancyDress : ArmorDecorator
    {
        public FancyDress(Personage personage)
        {
            this.personage = personage;
        }
        public override string GetDescription()
        {
            return personage.GetDescription() + ", Fancy Dress";
        }
        public override double Power()
        {
            return (personage.Power() + 0.30);
        }
        public override bool IsStrongerThan(Personage other)
        {
            return Power() > other.Power();
        }
        public override bool CanWinInFiveHits(Personage other)
        {
            return Power() * 5 > other.Power();
        }
        public override string ToString()
        {
            return GetDescription() + ":" + Power();
        }
    }
    class Suit : ArmorDecorator
    {
        public Suit(Personage personage)
        {
            this.personage = personage;
        }
        public override string GetDescription()
        {
            return personage.GetDescription() + ", Suit";
        }
        public override double Power()
        {
            return (personage.Power() + 0.10);
        }
        public override bool IsStrongerThan(Personage other)
        {
            return Power() > other.Power();
        }
        public override bool CanWinInFiveHits(Personage other)
        {
            return Power() * 5 > other.Power();
        }
        public override string ToString()
        {
            return GetDescription() + ":" + Power();
        }
    }


    class FacadePersonage
    {
        private Personage personage;

        public void ChoosePersonage()
        {
            Console.Clear();
            Console.WriteLine("Choose personage: \n 1 - Human\n 2 - Fairy\n 3 - JoJo\n 4 - Patron dog\n other - Exit");

            int choose = Convert.ToInt32(Console.ReadLine());
            switch (choose)
            {
                case 1: { personage = new Human(); break; }
                case 2: { personage = new Fairy(); break; }
                case 3: { personage = new JoJo(); break; }
                case 4: { personage = new PatronDog(); break; }
                default: { return; } 
            }

            ChooseWeapon();
            ChooseArmor();
            PrintPowerResult();
            CheckForStrongerOpponents();
            CheckForWinningInFiveHits();
        }


        public void ChooseWeapon()
        {
            if (personage != null)
            {
                Console.Clear();
                Console.WriteLine("Choose weapon:\n 1 - Ax\n 2 - Spell\n 3 - F16 \n 4 - Stick");

                int choose = Convert.ToInt32(Console.ReadLine());
                switch (choose)
                {
                    case 1: { AddAx(); break; }
                    case 2: { AddSpell(); break; }
                    case 3: { AddF16(); break; }
                    case 4: { AddStick(); break; }
                    default: { return; } 
                }
            }
        }

        public void ChooseArmor()
        {
            if (personage != null)
            {
                Console.Clear();
                Console.WriteLine("Choose armor:\n 1 - Metal armor \n 2 - Fancy dress \n 3 - Suit");

                int choose = Convert.ToInt32(Console.ReadLine());
                switch (choose)
                {
                    case 1: { AddMetalArmor(); break; }
                    case 2: { AddFancyDress(); break; }
                    case 3: { AddSuit(); break; }
                    default: { return; } 
                }
            }
        }

        public void AddAx()
        {
            personage = new Ax(personage);
        }
        public void AddSpell()
        {
            personage = new Spell(personage);
        }
        public void AddF16()
        {
            personage = new F16(personage);
        }
        public void AddStick()
        {
            personage = new Stick(personage);
        }
        public void AddMetalArmor()
        {
            personage = new MetalArmor(personage);
        }
        public void AddFancyDress()
        {
            personage = new FancyDress(personage);
        }
        public void AddSuit()
        {
            personage = new Suit(personage);
        }


        public void PrintPowerResult()
        {
            if (personage != null)
            {
                Console.Clear();
                Console.WriteLine("\n\nPersonage power: ");
                Console.WriteLine(personage.ToString());
                Console.WriteLine("Done!)\n\n");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Bye!:)\n\n");
            }
        }

        public void CheckForStrongerOpponents()
        {
            if (personage != null)
            {
                Console.WriteLine("Checking for stronger opponents...");

                Personage[] opponents = { new Human(), new Fairy(), new JoJo(), new PatronDog() };

                foreach (var opponent in opponents)
                {
                    if (personage.IsStrongerThan(opponent))
                    {
                        Console.WriteLine($"{personage.GetDescription()} can defeat {opponent.GetDescription()}!");
                    }
                    else
                    {
                        Console.WriteLine($"{personage.GetDescription()} cannot defeat {opponent.GetDescription()}.");
                    }
                }
            }
        }

        public void CheckForWinningInFiveHits()
        {
            if (personage != null)
            {
                Console.WriteLine("Checking for winning in 5 hits...");

                Personage[] opponents = { new Human(), new Fairy(), new JoJo(), new PatronDog() };

                foreach (var opponent in opponents)
                {
                    if (personage.CanWinInFiveHits(opponent))
                    {
                        Console.WriteLine($"{personage.GetDescription()} can win against {opponent.GetDescription()} in five 5 or less!");
                    }
                    else
                    {
                        Console.WriteLine($"{personage.GetDescription()} cannot win against {opponent.GetDescription()} in 5 hits.");
                    }
                }
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            FacadePersonage personagePower = new FacadePersonage();
            personagePower.ChoosePersonage();
        }
    }
}
