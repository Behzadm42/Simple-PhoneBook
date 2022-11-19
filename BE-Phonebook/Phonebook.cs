using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_Phonebook
{
    public class Phonebook
    {
        public Phonebook()
        {
            available = true;
        }
        public int id { get; set; }
        public string name{ get; set; }
        public string number { get; set; }
        public string address{ get; set; }
        public string note { get; set; }
       public bool available { get; set; }
    }
}
