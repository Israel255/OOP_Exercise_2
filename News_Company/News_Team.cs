using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News_Company
{
   abstract internal class News_Team
   {
        protected Story _story;

        internal abstract void Create_Story();
        internal Story Get_Story()
        {
            return _story;
        }
        internal virtual void Add_Style()
        {
            _story.Set_Visual_style("Black Backround");
        }

        public override string ToString()
        {
            return "Story: " + _story.ToString();
        }
    }
}
