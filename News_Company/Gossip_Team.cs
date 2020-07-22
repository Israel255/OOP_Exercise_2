using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News_Company
{
    class Gossip_Team : News_Team
    {
        internal override void Create_Story()
        {
            _story.Set_Title("Static And Ben-El");
            _story.Set_Body("Have A New Song");
        }

        public override string ToString()
        {
            return base.ToString() + " We Are Gossip Team";
        }
    }
}
