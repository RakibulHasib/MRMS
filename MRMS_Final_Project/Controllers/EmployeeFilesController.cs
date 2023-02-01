using Microsoft.AspNetCore.Mvc;
using MRMS.DAL;
using MRMS.Model.EmployeeSection;

namespace MRMS_Final_Project.Controllers
{
    //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]

    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeFilesController : ControllerBase
    {
        private IGlobalRepository _globalRepository;
        private IGenericRepository<EmployeeFile> _employyeefileRepository;


        public EmployeeFilesController(IGlobalRepository globalRepository)
        {
            this._globalRepository = globalRepository;
            this._employyeefileRepository = _globalRepository.EmployeeFileRepository;
        }


        [HttpGet]
        public IEnumerable<EmployeeFile> GetFileType()
        {
            return _employyeefileRepository.GetAll();
        }
        [HttpPost]
        public ActionResult EmployeeFilePost(EmployeeFile employeeFile)
        {
            _employyeefileRepository.Insert(employeeFile);
            _globalRepository.Save();
            return Ok(employeeFile);
        }

        [HttpPut("{id}")]
        public ActionResult EmployeeFilleUpdate(EmployeeFile employeeFile)
        {
            if (employeeFile.EmployeeFileId == 0)
            {
                return NoContent();
            }
            _employyeefileRepository.Update(employeeFile);
            _globalRepository.Save();
            return Ok(employeeFile);
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteEmployeeFile(int id)
        {
            var employeeFile = _employyeefileRepository.Get(id);
            if (employeeFile == null)
            {
                return NotFound();
            }
            _employyeefileRepository.Delete(employeeFile);
            _globalRepository.Save();
            return NoContent();
        }



        
    }
}
