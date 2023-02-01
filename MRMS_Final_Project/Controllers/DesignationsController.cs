using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MRMS.DAL;
using MRMS.Model.EmployeeSection;

namespace MRMS_Final_Project.Controllers
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [Route("api/[controller]")]
    [ApiController]
    public class DesignationsController : ControllerBase
    {

        private IGlobalRepository _globalRepository;
        private IGenericRepository<Designation> _designationRepository;


        public DesignationsController(IGlobalRepository globalRepository)
        {
            this._globalRepository = globalRepository;
            this._designationRepository = _globalRepository.DesignationRepository;
        }


        [HttpGet]
        public IEnumerable<Designation> GetFileType()
        {
            return _designationRepository.GetAll();
        }
        [HttpPost]
        public ActionResult DesignationPost(Designation designation)
        {
            _designationRepository.Insert(designation);
            _globalRepository.Save();
            return Ok(designation);
        }

        [HttpPut("{id}")]
        public ActionResult DesignationUpdate(Designation designation)
        {
            if (designation.DesignationId==0)
            {
                return NoContent();
            }
            _designationRepository.Update(designation);
            _globalRepository.Save();
            return Ok(designation);
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteDesignation(int id)
        {
            var desination = _designationRepository.Get(id);
            if (desination == null)
            {
                return NotFound();
            }
            _designationRepository.Delete(desination);
            _globalRepository.Save();
            return NoContent();
        }


        
    }
}
