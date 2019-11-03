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

        public Article this [int index]
        {
            get { return mystore[index]; }
            set {

                mystore[index] = value;
                }
        }
    }
}
