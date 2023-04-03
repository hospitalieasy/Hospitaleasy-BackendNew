using HastaneFinder.DataAcess.Abstract;
using HastaneFinder.Entitiy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneFinder.DataAcess.Concrete
{
    public class ContactRepository : IContactRepository
    {
        public Contact AddContact(Contact cont)
        {
            using (var hastaneDbContext = new HastaneDbContext())
            {
                hastaneDbContext.Contacts.Add(cont);
                hastaneDbContext.SaveChanges();
                return cont;

            }
        }

        public List<Contact> GetAllContact()
        {
            using (var HastaneDbContext = new HastaneDbContext())
            {
                return HastaneDbContext.Contacts.ToList();
            }
        }

        public Contact GetContactById(int id)
        {
            using (var hastaneDbContext = new HastaneDbContext())
            {
                return hastaneDbContext.Contacts.Find(id);
            }
        }
    }
}
