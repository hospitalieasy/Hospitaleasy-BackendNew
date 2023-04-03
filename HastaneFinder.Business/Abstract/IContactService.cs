using HastaneFinder.Entitiy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneFinder.Business.Abstract
{
    public interface IContactService
    {
        List<Contact> GetAllContact();

        Contact GetContactById(int id);
        Contact AddContact(Contact cont);
    }
}
