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
    public class HastaneManager : IHastaneService
    {
        private IHastaneRepository _HastaneRepository;

        public HastaneManager()
        {
            _HastaneRepository = new HastaneRepository();
        }

        public List<Hastaneler> GetAllHastaneler()
        {
          return _HastaneRepository.GetAllHastaneler();
        }

        public Hastaneler GetHastanelerById(int id)
        {
          if(id > 0)
            {
                return _HastaneRepository.GetHastanelerById(id);
            }
            throw new Exception("Id cannot be less than zero...");
        }

        public Hastaneler HastaneEkle(Hastaneler hastaneler)
        {
            return _HastaneRepository.HastaneEkle(hastaneler);
         
        }

        public Hastaneler HastaneGuncelleme(Hastaneler hastaneler)
        {
            return _HastaneRepository.HastaneGuncelleme(hastaneler);
           
        }

        public void HastaneSilById(int id)
        {
             _HastaneRepository.HastaneSilById(id);
         
        }
    }
}








