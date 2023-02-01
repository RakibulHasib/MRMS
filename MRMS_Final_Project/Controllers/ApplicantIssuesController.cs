using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MRMS.DAL;
using MRMS.Model.ApplicantSection;

namespace MRMS_Final_Project.Controllers
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicantIssuesController : ControllerBase
    {
        private IGlobalRepository _globalRepository;
        private IGenericRepository<ApplicantIssue> _applicantIssueRepository;

        public ApplicantIssuesController(IGlobalRepository globalRepository)
        {
            this._globalRepository = globalRepository;
            this._applicantIssueRepository = _globalRepository.ApplicantIssueRepository;
        }

        // GET:
        [HttpGet]
        public IEnumerable<ApplicantIssue> GetApplicantFiles()
        {
            return _applicantIssueRepository.GetAll();
        }

        //Insert:
        [HttpPost]
        public ActionResult PostApplicantFile(ApplicantIssue applicantIssue)
        {
            _applicantIssueRepository.Insert(applicantIssue);
            _globalRepository.Save();
            return Ok(applicantIssue);
        }

        //Update
        [HttpPut("{id}")]
        public IActionResult PutApplicantFile(int id, ApplicantIssue applicantIssue)
        {
            if (id != applicantIssue.ApplicantIssueId)
            {
                return BadRequest();
            }

            _applicantIssueRepository.Update(applicantIssue);

            try
            {
                _globalRepository.Save();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
            return Ok(applicantIssue);
        }

        // DELETE: 
        [HttpDelete("{id}")]
        public IActionResult DeleteApplicantIssue(int id)
        {
            var applicantIssue = _applicantIssueRepository.Get(id);
            if (applicantIssue == null)
            {
                return NotFound();
            }
            _applicantIssueRepository.Delete(applicantIssue);
            _globalRepository.Save();
            return NoContent();
        }

    }
}
