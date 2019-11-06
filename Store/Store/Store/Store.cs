using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    class Store
    {
        private Article[] mystore = new Article[5];
        

        public Store ()
        {
            mystore[0] = new Article("notebook", "AMD", 1500);
            mystore[1] = new Article("tv", "lg", 1200);
            mystore[2] = new Article("phone", "samsung", 800);
            mystore[3] = new Article("mouse", "logitech", 30);
            mystore[4] = new Article("monitor", "lg", 300);
        }

        public string this [int index]
        {
           get
            {
                if (index >= 0 && index < mystore.Length)
                {
                    return mystore[index].Show();
                }
                return "Попытка обращения за пределы массива.";
            }

        }

    public string this [string index]
        {
            get
            {
                for (int i = 0; i < mystore.Length; i++)
                {
                    if (mystore[i].Article_ == index)
                    {
                        return mystore[i].Show();
                    }
                    
                }
                return string.Format("{0} - нет в наличии", index);
            }
        }
        
    }
}
