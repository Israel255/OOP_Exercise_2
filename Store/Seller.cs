using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using News_Company;

namespace Store
{
    public class Seller
    {
        private int _money_earned;

        public void Sell_News_Paper(News_Paper news_Paper)
        {
            _money_earned += Convert.ToInt32(news_Paper.Get_Price());
        }
    }
}
