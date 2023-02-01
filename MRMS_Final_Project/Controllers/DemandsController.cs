using Microsoft.AspNetCore.Mvc;
using MRMS.DAL;
using MRMS.Model.DemandSection;

namespace MRMS_Final_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemandsController : ControllerBase
    {

        private IGlobalRepository _globalRepo;
        private IGenericRepository<Demand> _demandRepo;

        public DemandsController(IGlobalRepository globalRepo)
        {
            this._globalRepo= globalRepo;
            this._demandRepo = _globalRepo.DemandRepository;
        }

        //Get Data
        [HttpGet]
        public IEnumerable<Demand> GetDemands()
        {
            return _demandRepo.GetAll();
        }

        [HttpPost]
        public IActionResult  PostDemand(Demand demand)
        {
            _demandRepo.Insert(demand);
            _globalRepo.Save();
            return Ok(demand);
        }

        [HttpPut]
        public IActionResult UpdateDemand(Demand demand)
        {
            if (demand.DemandId == 0)
            {
                return NotFound();
            }           
            _demandRepo.Update(demand);
            _globalRepo.Save();

            return Ok(demand);

        }
        [HttpDelete("{id}")]
        public IActionResult DeleteDemand(int id)
        {   
            Demand demand= _demandRepo.Get(id);
            if(demand == null)
            {
                return NotFound();
            }
            _demandRepo.Delete(demand);
            _globalRepo.Save();
            return Ok(demand);
        }
    }
}
