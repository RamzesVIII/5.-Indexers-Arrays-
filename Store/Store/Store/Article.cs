using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    class Article
    {
        private string article;
        private readonly string store;
        private readonly double price;

        public string Article_
        {
            get { return article; }
            set { article = value; }
        }

        
        public Article (string article, string store, double price)
        {
            this.article = article;
            this.store = store;
            this.price = price;
        }

        public string Show ()
        {
            return string.Format(" Наименование товара - {0} \n Цена - {1} \n Магазин - {2}", article, price, store);
        }
    }
}
