using Microsoft.AspNetCore.Mvc;
using MRMS.DAL;
using MRMS.Model.ApplicationSection;

namespace MRMS_Final_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationsController : ControllerBase
    {
        private IGlobalRepository _globalRepo;
        private IGenericRepository<Application> _applicationRepo;
        public ApplicationsController(IGlobalRepository _globalRepo)
        {
            this._globalRepo = _globalRepo;
            this._applicationRepo = _globalRepo.ApplicationRepository;
        }

        //Get all Application
        [HttpGet]
        public IEnumerable<Application> GetApplications()
        {
            return _applicationRepo.GetAll();

        }

        //Insert Application
        [HttpPost]
        public IActionResult PostApplication(Application application)
        {
            _applicationRepo.Insert(application);
            _globalRepo.Save();
            return Ok(application);
        }

        //Update Application 
        [HttpPut]
        public IActionResult UpdateApplication(Application application)
        {
            if (application.ApplicationId  == 0)
            {
                return NotFound();
            }

            _applicationRepo.Update(application);
            _globalRepo.Save();
            return Ok(application);
        }

        //Delete Application
        [HttpDelete("{id}")]
        public IActionResult DeleteApplication(int id)
        {
            Application application = _applicationRepo.Get(id);
            if (application == null)
            {
                return NotFound();
            }

            _applicationRepo.Delete(application);
            _globalRepo.Save();
            return Ok(application);
        }
    }
}
