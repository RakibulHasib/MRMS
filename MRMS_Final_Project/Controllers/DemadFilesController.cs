using Microsoft.AspNetCore.Mvc;
using MRMS.DAL;
using MRMS.Model.DemandSection;

namespace MRMS_Final_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemadFilesController : ControllerBase
    {

        private IGlobalRepository _globalRepo;      
        private IGenericRepository<DemandFile> _demandFileRepo;
        
        public DemadFilesController(IGlobalRepository globalRepo)
        {
            this._globalRepo = globalRepo;           
            this._demandFileRepo = _globalRepo.DemandFileRepository;
        }

        //Get DemandFiles
        [HttpGet]
        public IEnumerable<DemandFile> GetDemandFiles()
        {
            return _demandFileRepo.GetAll();
        }

        //Post Demand File
        [HttpPost]
        public IActionResult PostDemandFile(DemandFile  demandFile)
        {
            _demandFileRepo.Insert(demandFile);
            _globalRepo.Save();
            return Ok(demandFile);
        }

        //Update DemandFile
        [HttpPut]
        public IActionResult UpdateDemandFile(DemandFile demandFile)
        {
            if (demandFile.DemandFileId == 0)
            {
                return NotFound();
            }
            _demandFileRepo.Update(demandFile);
            _globalRepo.Save();
            return Ok(demandFile);

        }

        //Delete Demand File
        [HttpDelete("{id}")]
        public IActionResult DeleteDemandFile(int id)
        {
            DemandFile demandFile = _demandFileRepo.Get(id);
            if (demandFile == null)
            {
                return NotFound();
            }
            _demandFileRepo.Delete(demandFile);
            _globalRepo.Save();
            return Ok(demandFile);
        }
    }
}
