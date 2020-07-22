using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News_Company
{
    internal class Politics_Team : News_Team
    {
        internal override void Create_Story()
        {
            _story.Set_Title("Bibi");
            _story.Set_Body("He Is The Prime Minister");
        }

        internal override void Add_Style()
        {
            _story.Set_Visual_style("White Backround");
        }

        public override string ToString()
        {
            return base.ToString() + " We Are The Politic Team";
        }
    }
}
