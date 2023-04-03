using HastaneFinder.Entitiy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneFinder.DataAcess.Abstract
{
    public interface IContactRepository
    {
        List<Contact> GetAllContact();

        Contact GetContactById(int id);
        Contact AddContact(Contact cont);
    }
}
