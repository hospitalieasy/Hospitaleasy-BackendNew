using HastaneFinder.Entitiy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneFinder.Business.Abstract
{
    public interface IHastaneService
    {
        List<Hastaneler> GetAllHastaneler();

        Hastaneler GetHastanelerById(int id);
        Hastaneler HastaneEkle(Hastaneler hastaneler);
        Hastaneler HastaneGuncelleme(Hastaneler hastaneler);
        void HastaneSilById(int id);
    }
}
