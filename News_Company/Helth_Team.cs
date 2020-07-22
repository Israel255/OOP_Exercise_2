using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News_Company
{
    class Helth_Team : News_Team
    {
        internal override void Create_Story()
        {
            _story.Set_Title("Corona Virus");
            _story.Set_Body("1977 Carries Today");
        }

        internal override void Add_Style()
        {
            _story.Set_Visual_style("Yellow Backround");
        }

        public override string ToString()
        {
            return base.ToString() + " We Are Helth Team";
        }
    }
}
