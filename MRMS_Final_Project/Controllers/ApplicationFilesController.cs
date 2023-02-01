using Microsoft.AspNetCore.Mvc;
using MRMS.DAL;
using MRMS.Model.ApplicationSection;

namespace MRMS_Final_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationFilesController : ControllerBase
    {
        private IGlobalRepository _globalRepo;
        private IGenericRepository<ApplicationFile> _applicationFileRepo;
        public ApplicationFilesController(IGlobalRepository _globalRepo)
        {
            this._globalRepo = _globalRepo;
            this._applicationFileRepo = _globalRepo.ApplicationFileRepository;
        }

        //Get Data
        [HttpGet]
        public IEnumerable<ApplicationFile> GetApplicationFiles()
        {
            return _applicationFileRepo.GetAll();

        }
        //Post data
        [HttpPost]
        public IActionResult PostApplicationFile(ApplicationFile applicationFile)
        {
            _applicationFileRepo.Insert(applicationFile);
            _globalRepo.Save();
            return Ok(applicationFile);
        }
        // Update
        [HttpPut]
        public IActionResult UpdateApplicationFile(ApplicationFile applicationFile)
        {
            if (applicationFile.ApplicationFileId == 0)
            {
                return NotFound();
            }

            _applicationFileRepo.Update(applicationFile);
            _globalRepo.Save();
            return Ok(applicationFile);
        }
        // Delete data
        [HttpDelete("{id}")]
        public IActionResult DeleteApplicationFile(int id)
        {
            ApplicationFile applicationFile = _applicationFileRepo.Get(id);
            if (applicationFile == null)
            {
                return NotFound();
            }

            _applicationFileRepo.Delete(applicationFile);
            _globalRepo.Save();
            return Ok(applicationFile);
        }
    }
}
