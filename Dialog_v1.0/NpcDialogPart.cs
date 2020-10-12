using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dialog_v1._0
{
    public class NpcDialogPart
    {

        public NpcDialogPart(string text, int index)
        {
            replicaNpc = text;
            heroDialogs = new List<HeroDialogPart>();
            indexNext = index;
        }

        public int indexNext { get; set; }
        public string replicaNpc { get; set; }
        public List<HeroDialogPart> heroDialogs; 
    }
}
