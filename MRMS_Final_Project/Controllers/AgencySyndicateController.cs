using Microsoft.AspNetCore.Mvc;
using MRMS.DAL;
using MRMS.Model.AgencySection;

namespace MRMS_Final_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgencySyndicateController : ControllerBase
    {
        private IGlobalRepository _globalRepository;
        private IGenericRepository<AgencySyndicate> _agencySyndicateRepository;


        public AgencySyndicateController(IGlobalRepository globalRepository)
        {
            this._globalRepository = globalRepository;
            this._agencySyndicateRepository = _globalRepository.AgencySyndicateRepository;
        }

        //Get Syndicate Agency List
        [HttpGet]
        public IEnumerable<AgencySyndicate> GetAgencySyndicate()
        {
            return _agencySyndicateRepository.GetAll();
        }

        //Post Syndicate Agency
        [HttpPost]
        public IActionResult AgencySyndicatePost(AgencySyndicate agencySyndicate)
        {
            _agencySyndicateRepository.Insert(agencySyndicate);
            _globalRepository.Save();
            return Ok(agencySyndicate);
        }

        //Update Syndicate Agency
        [HttpPut]
        public IActionResult AgencySyndicateUpdate(AgencySyndicate agencySyndicate)
        {
            if (agencySyndicate.AgencySyndicateId == 0)
            {
                return NotFound();
            }
            _agencySyndicateRepository.Update( agencySyndicate);
            _globalRepository.Save();
            return Ok(agencySyndicate);
        }

        //Delete Agency
        [HttpDelete("{id}")]
        public IActionResult DeleteAgencySyndicate(int id)
        {
            AgencySyndicate  agencySyndicate = _agencySyndicateRepository.Get(id);
            if (agencySyndicate == null)
            {
                return NotFound();
            }

            _agencySyndicateRepository.Delete(agencySyndicate);
            _globalRepository.Save();
            return Ok(agencySyndicate);
        }
    }
}
