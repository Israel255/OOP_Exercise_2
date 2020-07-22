using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News_Company
{
    public class News_Paper
    {
        private const int _NUMBER_OF_STORIES = 3;
        private float _price;
        private Story[] _stories = new Story[_NUMBER_OF_STORIES];

        public News_Paper(Story[] stories, float price)
        {
            Set_Stories(stories);
            Set_Price(price);
        }

        public Story[] Get_Stories()
        {
            return _stories;
        }
        public void Set_Stories(Story[] stories)
        {
            for (int i = _NUMBER_OF_STORIES - 1; i == stories.Length -1; i++)
            {
                if (stories[i] != null)
                {
                    _stories = stories;
                }
                else
                {
                    Console.WriteLine("Eror");
                }
            }
        }

        public float Get_Price()
        {
            return _price;
        }
        public void Set_Price(float price)
        {
            if (price > 0)
            {
                _price = price;
            }
            else
            {
                Console.WriteLine("This Is Not Israel Today!!!");
            }
        }

        public override string ToString()
        {
            return "Newspaper price: " + _price + " Number Of Stories In Newspaper: " + _NUMBER_OF_STORIES;
        }
    }
}
