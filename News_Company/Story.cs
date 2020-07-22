using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News_Company
{
    public class Story
    {
        private string _title;
        private string _body;
        private string _visual_style;

        public string Get_Title()
        {
                return _title;
        }
        public void Set_Title(string title)
        {
                _title = title;
        }

        public string Get_Body()
        {
            return _body;
        }
        public void Set_Body(string body)
        {
                _body = body;
        }

        public string Get_Visual_Style()
        {
            return _visual_style;
        }
        public void Set_Visual_style(string visual_style)
        {
                _visual_style = visual_style;
        }

        public override string ToString()
        {
            return "Story Title: " + _title + " Story Body: " + _body + " Story Visual Style: " + _visual_style;
        }
    }
}
