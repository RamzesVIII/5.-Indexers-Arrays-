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
        private string store;
        private double price;

        
        public Article (string article, string store, double price)
        {
            this.article = article;
            this.store = store;
            this.price = price;
        }
    }
}
