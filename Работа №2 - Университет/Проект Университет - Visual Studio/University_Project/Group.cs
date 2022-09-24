using System;
using System.Collections.Generic;
using System.Text;

namespace University_Project
{
    class Group
    {
        public int ID { get; set; }
        public string Group_Name { get; set; }

        public Group(int iD, string group_Name)
        {
            ID = iD;
            Group_Name = group_Name;
        }
        public override string ToString()
        {
            return String.Format(ID + " " + Group_Name);
        }
    }
}
