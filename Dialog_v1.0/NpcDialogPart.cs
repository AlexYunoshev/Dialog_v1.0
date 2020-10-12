using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dialog_v1._0
{
    public class NpcDialogPart
    {

        public NpcDialogPart(string text)
        {
            replicaNpc = text;
            heroDialogs = new List<HeroDialogPart>();
        }

        public string replicaNpc { get; set; }
        public List<HeroDialogPart> heroDialogs; 
    }
}
