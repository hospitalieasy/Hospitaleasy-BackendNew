using HastaneFinder.Business.Abstract;
using HastaneFinder.DataAcess.Abstract;
using HastaneFinder.DataAcess.Concrete;
using HastaneFinder.Entitiy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneFinder.Business.Concrete
{
    public class ContactManager : IContactService
    {
        private readonly IContactRepository repo;

        public ContactManager()
        {
            repo = new ContactRepository();
        }
        public Contact AddContact(Contact cont)
        {
           return repo.AddContact(cont);
        }

        public List<Contact> GetAllContact()
        {
            return repo.GetAllContact();
        }

        public Contact GetContactById(int id)
        {
            return repo.GetContactById(id);
        }
    }
}
