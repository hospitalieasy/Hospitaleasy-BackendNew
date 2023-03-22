using HastaneFinder.DataAcess.Abstract;
using HastaneFinder.Entitiy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneFinder.DataAcess.Concrete
{

    public class HastaneRepository : IHastaneRepository
    {
        public List<Hastaneler> GetAllHastaneler()
        {
           using(var HastaneDbContext = new HastaneDbContext())
            {
                return HastaneDbContext.hastaneler.ToList();
            }
        }

        public Hastaneler GetHastanelerById(int id)
        {
            using(var hastaneDbContext = new HastaneDbContext())
            {
                return hastaneDbContext.hastaneler.Find(id);
            }
           
        }

        public Hastaneler HastaneEkle(Hastaneler hastaneler)
        {
            using(var hastaneDbContext =new HastaneDbContext())
            {
                hastaneDbContext.hastaneler.Add(hastaneler);
                hastaneDbContext.SaveChanges();
                return hastaneler;

            }

        }

        public Hastaneler HastaneGuncelleme(Hastaneler hastaneler)
        {
           using(var hastaneDbContext = new HastaneDbContext())
            {
                hastaneDbContext.hastaneler.Update(hastaneler);
                hastaneDbContext.SaveChanges();
                return hastaneler;
            }
        }

        public void HastaneSilById(int id)
        {
            using(var hastaneDbContext = new HastaneDbContext())
            {
                var silinenHastane = GetHastanelerById(id);
                hastaneDbContext.hastaneler.Remove(silinenHastane);
                hastaneDbContext.SaveChanges();
            }
            
        }
    }
}
