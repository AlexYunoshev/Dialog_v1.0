using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dialog_v1._0
{
    public class HeroDialogPart
    {
        public HeroDialogPart(string text)
        {
            replicaHero = text;
            npcDialogs = new List<NpcDialogPart>();
        }

        public string replicaHero { get; set; }
        public List<NpcDialogPart> npcDialogs;
    }
}
