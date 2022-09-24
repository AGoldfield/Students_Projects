using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Project
{
    class Book
    {
        public int ID { get; set; }
        public string Book_Name { get; set; }
        public Book(int ID, string Book_Name)
        {
            this.ID = ID;
            this.Book_Name = Book_Name;
        }
        public override string ToString()
        {
            return String.Format(ID + " " + Book_Name);
        }
    }
}
