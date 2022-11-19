using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE_Phonebook;
using DA_Phonebook;


namespace BL_Phonebook
{
    public class BLPhonebook
    {
        public bool insert(Phonebook ph)
        {
            if (UInt64.Parse(ph.number) >= 0)
            {
                DAPhonebook dap = new DAPhonebook();
                dap.insert(ph);
                return true;
            }
            else
                return false;
        }
        public IEnumerable<object> read()
        {
            DAPhonebook dap = new DAPhonebook();
            var z = dap.read();
            //  var z = new db().humans1.Where(i => i.available == true).Select(i => new { i.name, i.family, i.age }).ToList();
            return z;
        }
        public Phonebook read(int id)
        {
            DAPhonebook dap = new DAPhonebook();
            Phonebook z = dap.read(id);
            //  var z = new db().humans1.Where(i => i.available == true).Select(i => new { i.name, i.family, i.age }).ToList();
            return z;
        }
        public IEnumerable<object> read(string s)
        {
            DAPhonebook dap = new DAPhonebook();
            var z = dap.read(s);
            //  var z = new db().humans1.Where(i => i.available == true).Select(i => new { i.name, i.family, i.age }).ToList();
            return z;
        }

        public void delete3(int id1)
        {
            DAPhonebook dap = new DAPhonebook();
            dap.delete3(id1);
        }
        public Boolean exist(Phonebook ph)
        {

            DAPhonebook dap = new DAPhonebook();
            return dap.exist(ph);
        }
        public void update(int id1, Phonebook hh)
        {
            DAPhonebook dap = new DAPhonebook();
            dap.update(id1,hh);
        }

    }
}
