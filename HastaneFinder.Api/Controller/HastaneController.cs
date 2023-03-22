using HastaneFinder.Business.Abstract;
using HastaneFinder.Business.Concrete;
using HastaneFinder.Entitiy;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HastaneFinder.Api.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class HastaneController : ControllerBase
    {
        private IHastaneService _hastaneService;

        public HastaneController()
        {
            _hastaneService = new HastaneManager();
        }

        [HttpGet]
        public List<Hastaneler> Get()
        {
            return _hastaneService.GetAllHastaneler();
        }

        [HttpGet("{id}")]
        public Hastaneler Get(int id)
        {
            return _hastaneService.GetHastanelerById(id);
        }
        [HttpPost]

        public Hastaneler Post([FromBody] Hastaneler hastaneler)
        {
            return _hastaneService.HastaneEkle(hastaneler);
        }


        [HttpPut]
        public Hastaneler Put([FromBody] Hastaneler hastaneler)
        {

            return _hastaneService.HastaneGuncelleme(hastaneler);


        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

            _hastaneService.HastaneSilById(id);


        }
    }
}
