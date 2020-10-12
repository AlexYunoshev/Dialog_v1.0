using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dialog_v1._0
{
    public class HeroDialogPart
    {
        public HeroDialogPart(string text, bool end)
        {
            replicaHero = text;
            npcDialogs = new List<NpcDialogPart>();
            exitHero = end;
        }

        public bool exitHero { get; set; }
        public string replicaHero { get; set; }
        public List<NpcDialogPart> npcDialogs;
    }
}
