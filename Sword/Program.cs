using System;

namespace Sword
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            SwordDamage swordDamage = new SwordDamage();

            while (true)
            {
                Console.Write("0 fo no magic/flaming, 1 for magic, 2 for flaming, 3 for both, anything else to quit: ");
                char num = Console.ReadKey().KeyChar;
                if (num != '0' && num != '1' && num != '2' && num != '3') return;

                //3d6
                int roll = 0;
                for (int i = 0; i < 3; i++)
                {
                    roll += random.Next(1, 7);
                }

                swordDamage.Roll = roll;
                if (num == '1' || num == '3')
                {
                    swordDamage.SetMagic(true);
                }
                else
                {
                    swordDamage.SetMagic(false);
                }

                if (num == '2' || num == '3')
                {
                    swordDamage.SetFlaming(true);
                }
                else
                {
                    swordDamage.SetFlaming(false);
                }

                Console.WriteLine("\nRolled " + roll + " for " + swordDamage.Damage + " HP\n");

            }
        }
    }
}
