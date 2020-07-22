using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News_Company
{
    class News_Paper_Calculator
    {
        public int Calc_Number_Of_Chars(News_Paper news_Paper)
        {
            int chars = 0;
            for (int i = 0; i < news_Paper.Get_Stories().Length; i++)
            {
              chars += news_Paper.Get_Stories()[i].Get_Title().Length;
                chars += news_Paper.Get_Stories()[i].Get_Body().Length;
            }
            return chars;
        }
    }
}
