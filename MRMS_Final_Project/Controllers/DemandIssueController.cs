using Microsoft.AspNetCore.Mvc;
using MRMS.DAL;
using MRMS.Model.DemandSection;

namespace MRMS_Final_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemandIssueController : ControllerBase
    {
        private IGlobalRepository _globalRepo;       
        private IGenericRepository<DemandIssue> _demandIssueRepo;

        public DemandIssueController(IGlobalRepository globalRepo)
        {
            this._globalRepo = globalRepo;            
            this._demandIssueRepo = _globalRepo.DemandIssueRepository;
        }


        //Get Demand Issues
        [HttpGet]
        public IEnumerable<DemandIssue> GetDemandIssues()
        {
            return _demandIssueRepo.GetAll();
        }

        //Post Demand Issue
        [HttpPost]
        public IActionResult PostDemandIssue(DemandIssue demandIssue)
        {

            _demandIssueRepo.Insert(demandIssue);

            _globalRepo.Save();
            return Ok(demandIssue);
        }

        [HttpPut]
        public IActionResult UpdateDemandIssue(DemandIssue demandIssue)
        {
            if (demandIssue.DemandIssueId == 0)
            {
                return NoContent();
            }

            _demandIssueRepo.Update(demandIssue);
            _globalRepo.Save();
            return Ok(demandIssue);
        }

        //Delete Demand Issue
        [HttpDelete("{id}")]
        public IActionResult DeleteDemandIssue(int id)
        {
            DemandIssue demandIssue = _demandIssueRepo.Get(id);
            if (demandIssue == null)
            {
                return NotFound();
            }
            _demandIssueRepo.Delete(demandIssue);
            _globalRepo.Save();
            return Ok(demandIssue);
        }
    }
}
