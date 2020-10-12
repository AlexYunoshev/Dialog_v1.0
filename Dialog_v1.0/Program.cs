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
  
            List<NpcDialogPart> masNpc = new List<NpcDialogPart>();
            List<HeroDialogPart> masHero = new List<HeroDialogPart>();
           

            ////////////////////////////////////////////////////////////////////////////////////////////////

            
            NpcDialogPart npc0 = new NpcDialogPart("NPC: Привiт, допоможи менi дiстатись iншого мiста.", 1);
            

            HeroDialogPart hero0_1 = new HeroDialogPart("HERO: Так, допоможу!");
            HeroDialogPart hero0_2 = new HeroDialogPart("HERO: Нi, не допоможу");

            npc0.heroDialogs.Add(hero0_1);
            npc0.heroDialogs.Add(hero0_2);


            NpcDialogPart npc1 = new NpcDialogPart("NPC: Дякую, я дам тобi 100 монет у нагороду.", 1);
           

            hero0_1.npcDialogs.Add(npc1);


            HeroDialogPart hero1_1 = new HeroDialogPart("HERO: Ок, скажу коли буду готовий.");
            HeroDialogPart hero1_2 = new HeroDialogPart("HERO: 100 монет дуже мало!");
            HeroDialogPart hero1_3 = new HeroDialogPart("HERO: 100 монет дуже багато!");



            npc1.heroDialogs.Add(hero1_1);
            npc1.heroDialogs.Add(hero1_2);
            npc1.heroDialogs.Add(hero1_3);

            NpcDialogPart npc2_1 = new NpcDialogPart("NPC: Не маю бiльше, я дуже бiдний.", 1);
            NpcDialogPart npc2_2 = new NpcDialogPart("NPC: А скiльки ти хочеш?", 2);
            
            hero1_2.npcDialogs.Add(npc2_1);
            hero1_3.npcDialogs.Add(npc2_2);


            HeroDialogPart hero2_1 = new HeroDialogPart("HERO: Ок, нехай буде 100 монет.");
            HeroDialogPart hero2_2 = new HeroDialogPart("HERO: Тодi сам добирайся");
            HeroDialogPart hero2_3 = new HeroDialogPart("HERO: 20 вистачить");
            HeroDialogPart hero2_4 = new HeroDialogPart("HERO: 40 вистачить");

            npc2_1.heroDialogs.Add(hero2_1);
            npc2_1.heroDialogs.Add(hero2_2);

            npc2_2.heroDialogs.Add(hero2_3);
            npc2_2.heroDialogs.Add(hero2_4);


            NpcDialogPart npc3_1 = new NpcDialogPart("NPC: Дякую", 2);
           
            NpcDialogPart npc3_2 = new NpcDialogPart("NPC: Домовились", 2);
        
           

            hero2_1.npcDialogs.Add(npc3_1);
            hero2_3.npcDialogs.Add(npc3_2);
            hero2_4.npcDialogs.Add(npc3_2);

            ////////////////////////////////////////////////////////////////////////////////////////////////

            masNpc.Add(npc0); // 0
            masNpc.Add(npc1); // 1
            masNpc.Add(npc2_1); // 2
            masNpc.Add(npc2_2); // 3
            masNpc.Add(npc3_1); // 4
            masNpc.Add(npc3_2); // 5

            masHero.Add(hero0_1); // 0
            masHero.Add(hero0_2); // 1
            masHero.Add(hero1_1); // 2
            masHero.Add(hero1_2); // 3
            masHero.Add(hero1_3); // 4
            masHero.Add(hero2_1); // 5
            masHero.Add(hero2_2); // 6
            masHero.Add(hero2_3); // 7
            masHero.Add(hero2_4); // 8

            int ind = 0;
            int index = 0;
            Console.WriteLine(masNpc[index].replicaNpc);
            if (masNpc[index].heroDialogs.Count == 0)
            {
                Console.WriteLine("КIНЕЦЬ!!!");
                return;
            }
            while (true)
            {               
                int i = 1;
                if (masNpc[index].heroDialogs.Count == 0)
                {
                    Console.WriteLine("КIНЕЦЬ!!!");
                    return;
                }
                foreach (HeroDialogPart value in masNpc[index].heroDialogs)
                {
                    Console.WriteLine(i + ") " + value.replicaHero);
                    i++;
                }
                choiceHero = Convert.ToInt32(Console.ReadLine());
               
                if (masNpc[index].heroDialogs[choiceHero - 1].npcDialogs.Count == 0)
                {
                    Console.WriteLine("КIНЕЦЬ!!!");
                    return;
                }
                foreach (NpcDialogPart value in masNpc[index].heroDialogs[choiceHero - 1].npcDialogs)
                {
                    Console.WriteLine(value.replicaNpc);
                    ind = value.indexNext;
                }

                index = index + ind;
            }


        }
    }
}
