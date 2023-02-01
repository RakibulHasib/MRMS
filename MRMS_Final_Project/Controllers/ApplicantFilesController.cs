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
    public class ApplicantFilesController : ControllerBase
    {
        private IGlobalRepository _globalRepository;
        private IGenericRepository<ApplicantFile> _applicantFileRepository;

        public ApplicantFilesController(IGlobalRepository globalRepository)
        {
            this._globalRepository = globalRepository;
            this._applicantFileRepository = _globalRepository.ApplicantFileRepository;
        }


        // GET:
        [HttpGet]
        public IEnumerable<ApplicantFile> GetApplicantFiles()
        {
            return _applicantFileRepository.GetAll();
        }

        //Insert:
        [HttpPost]
        public ActionResult PostApplicantFile(ApplicantFile applicantFile)
        {
            _applicantFileRepository.Insert(applicantFile);
            _globalRepository.Save();
            return Ok(applicantFile);
        }

        //Update
        [HttpPut("{id}")]
        public IActionResult PutApplicantFile(int id,ApplicantFile applicantFile)
        {
            if (id != applicantFile.ApplicantFileId)
            {
                return BadRequest();
            }

            _applicantFileRepository.Update(applicantFile);

            try
            {
                _globalRepository.Save();
            }
            catch (DbUpdateConcurrencyException)
            {
                    throw;
            }
            return Ok(applicantFile);
        }
        // DELETE: 
        [HttpDelete("{id}")]
        public IActionResult DeleteApplicantFile(int id)
        {
            var applicantFile = _applicantFileRepository.Get(id);
            if (applicantFile == null)
            {
                return NotFound();
            }
            _applicantFileRepository.Delete(applicantFile);
            _globalRepository.Save();
            return NoContent();
        }
    }
}
