using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE_Phonebook;

namespace DA_Phonebook
{
    public class DAPhonebook
    {
        public void insert(Phonebook ph)
        {
            DB db1 = new DB();
            db1.phonebooks.Add(ph);
            db1.SaveChanges();
        }
        public IEnumerable<object> read()
        {
            DB db1 = new DB();
            //    var z = db1.phonebooks.Select(i => new { i.name, i.family, i.age }).ToList();
            var z = db1.phonebooks.Where(i => i.available == true).Select(i => new {i.id,i.name, i.number, i.address,i.note }).ToList();
            return z;
        }
        public Phonebook read(int id1)
        {
            var q = new DB().phonebooks.Where(i => i.id == id1);
            return q.Single();

        }
        public IEnumerable<object> read(string s)
        {

            var q = new DB().phonebooks.Where(i => (i.name.Contains(s) || i.number.Contains(s)) && i.available == true).Select(i => new { i.id, i.name, i.number, i.address, i.note }).ToList();
            return q;


        }
        public void delete3(int id1)
        {
            DB db1 = new DB();

            var q = db1.phonebooks.Where(i => i.id == id1);
            if (q.Single() != null)//q.count==1
            {
               q.Single().available = false;
            }
            db1.SaveChanges();
        }
        public Boolean exist(Phonebook ph)
        {

            foreach (var item in new DB().phonebooks)
            {
                if (item.name == ph.name && item.number == ph.number)
                    return true;
            }
            return false;
        }
        public void update(int id1, Phonebook hh)
        {
            DB db1 = new DB();
            Phonebook ph = new Phonebook();
            if (exist(hh) != true)
            {
                var q = db1.phonebooks.Where(i => i.id == id1);
                if (q.Count() == 1)
                {
                    ph = q.Single();
                    ph.name = hh.name;
                    ph.number = hh.number;
                    ph.address = hh.address;
                    ph.note = hh.note;
                    ph.available = hh.available;
                    db1.SaveChanges();
                }
            }

        }
    }
}
