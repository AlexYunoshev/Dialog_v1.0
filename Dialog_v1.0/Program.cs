using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dialog_v1._0
{
    class Program
    {
        

        static void Main(string[] args)
        {
            int choiceHero;
            int choiceNpc;

            List<NpcDialogPart> masNpc = new List<NpcDialogPart>();

            NpcDialogPart npc1 = new NpcDialogPart("NPC: Привiт, допоможи менi дiстатись iншого мiста.");

            HeroDialogPart hero1_1 = new HeroDialogPart("HERO: Так, допоможу!");
            HeroDialogPart hero1_2 = new HeroDialogPart("HERO: Нi, не допоможу");

            npc1.heroDialogs.Add(hero1_1);
            npc1.heroDialogs.Add(hero1_2);

            NpcDialogPart npc2 = new NpcDialogPart("NPC: Дякую, я дам тобi 100 монет у нагороду.");

            hero1_1.npcDialogs.Add(npc2);


            HeroDialogPart hero2_1 = new HeroDialogPart("HERO: Ок, скажу коли буду готовий.");
            HeroDialogPart hero2_2 = new HeroDialogPart("HERO: 100 монет дуже мало!");



            npc2.heroDialogs.Add(hero2_1);
            npc2.heroDialogs.Add(hero2_2);

            NpcDialogPart npc3 = new NpcDialogPart("NPC: Не маю бiльше, я дуже бiдний.");

            hero2_2.npcDialogs.Add(npc3);

            HeroDialogPart hero3_1 = new HeroDialogPart("HERO: Ок, нехай буде 100 монет.");
            HeroDialogPart hero3_2 = new HeroDialogPart("HERO: Тодi сам добирайся");

            npc3.heroDialogs.Add(hero3_1);
            npc3.heroDialogs.Add(hero3_2);


            NpcDialogPart npc4 = new NpcDialogPart("NPC: Дякую");

            hero3_1.npcDialogs.Add(npc4);


            while (true)
            {
                Console.WriteLine(npc1.replicaNpc);
                int i = 1;
                foreach (HeroDialogPart value in npc1.heroDialogs)
                {
                    Console.WriteLine(i + ") " + value.replicaHero);
                    i++;
                }
                choiceHero = Convert.ToInt32(Console.ReadLine());

                switch(choiceHero)
                {
                    case 1:
                        foreach (NpcDialogPart value in npc1.heroDialogs[choiceHero - 1].npcDialogs)
                        {
                            Console.WriteLine(value.replicaNpc);
                            i = 1;
                            foreach (HeroDialogPart value1 in npc2.heroDialogs)
                            {
                                Console.WriteLine(i + ") " + value1.replicaHero);
                                i++;
                            }
                            choiceHero = Convert.ToInt32(Console.ReadLine());
                        }

                        break;
                    case 2:
                        Console.WriteLine("КIНЕЦЬ");
                        break;
                }
                break;
            }


        }
    }
}
