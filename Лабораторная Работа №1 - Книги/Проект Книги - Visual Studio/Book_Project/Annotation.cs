using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Project
{
    class Annotation
    {
        public int ID { get; set; }
        public string Annotation_Text { get; set; }
        public int Book_ID { get; set; }
        public Annotation(int ID, string Annotation_Text, int Book_ID)
        {
            this.ID = ID;
            this.Annotation_Text = Annotation_Text;
            this.Book_ID = Book_ID;
        }
        public override string ToString()
        {
            return String.Format(ID + " " + Annotation_Text + " " + Book_ID);
        }
    }
}
