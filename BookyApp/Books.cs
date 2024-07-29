using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookyApp
{
    public class Books
    {
        private double price;
        private string title;
        private string description;
        private string author;
        private string genre;

        public Books(double price, string title, string description, string author, string genre)
        {
            this.price = price;
            this.title = title;
            this.description = description;
            this.author = author;
            this.genre = genre;
        }

        public object this[int index]
        {
            get
            {
                if (index == 0)
                    return this.price;
                else if (index == 1) 
                    return this.title;
                else if (index == 2)
                    return this.description;
                else if (index == 3)
                    return this.author;
                else if (index == 4)
                    return this.genre;
                return null;
            }
            set
            {
                if (index == 0)
                    this.price = (double) value;
                else if (index == 1)
                    this.title = (string) value;
                else if (index == 2)
                    this.description = (string) value;
                else if (index == 3)
                    this.author = (string) value;
                else if (index == 4)
                    this.genre = (string) value;
            }
        }

        public object this[string attrName]
        {
            get
            {
                if (attrName.ToLower().Equals("price"))
                    return this.price;
                else if (attrName.ToLower().Equals("title"))
                    return this.title;
                else if(attrName.ToLower().Equals("description"))
                    return this.description;
                else if (attrName.ToLower().Equals("author"))
                    return this.author;
                else if (attrName.ToLower().Equals("genre"))
                    return this.genre;
                return null;
            }
            set
            {
                if (attrName.ToLower().Equals("price"))
                    this.price = (double) value;
                else if (attrName.ToLower().Equals("title"))
                    this.title = (string) value;
                else if (attrName.ToLower().Equals("description"))
                    this.description = (string) value;
                else if (attrName.ToLower().Equals("author"))
                    this.author = (string) value;
                else if (attrName.ToLower().Equals("genre"))
                    this.genre = (string) value;
            }
        }
    }
}
