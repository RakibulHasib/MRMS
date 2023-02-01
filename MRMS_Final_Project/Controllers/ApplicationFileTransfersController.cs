using Microsoft.AspNetCore.Mvc;
using MRMS.DAL;
using MRMS.Model.ApplicationSection;

namespace MRMS_Final_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationFileTransfersController : ControllerBase
    {
        private IGlobalRepository _globalRepo;
        private IGenericRepository<ApplicationFileTransfer> _applicationFileTransferRepo;

        public ApplicationFileTransfersController(IGlobalRepository _globalRepo)
        {
            this._globalRepo = _globalRepo;
            this._applicationFileTransferRepo = _globalRepo.ApplicationFileTransferRepository;
        }

        //Get Data
        [HttpGet]
        public IEnumerable<ApplicationFileTransfer> GetApplicationFileTransfers()
        {
            return _applicationFileTransferRepo.GetAll();

        }
        [HttpPost]
        public IActionResult PostApplicationFileTransfer(ApplicationFileTransfer applicationFileTransfer)
        {
            _applicationFileTransferRepo.Insert(applicationFileTransfer);
            _globalRepo.Save();
            return Ok(applicationFileTransfer);
        }
        [HttpPut]
        public IActionResult UpdateApplicationFileTransfer(ApplicationFileTransfer applicationFileTransfer)
        {
            if (applicationFileTransfer.ApplicationFileTransferId == 0)
            {
                return NotFound();
            }

            _applicationFileTransferRepo.Update(applicationFileTransfer);
            _globalRepo.Save();
            return Ok(applicationFileTransfer);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteApplicationIssue(int id)
        {
            ApplicationFileTransfer applicationFileTransfer = _applicationFileTransferRepo.Get(id);
            if (applicationFileTransfer == null)
            {
                return NotFound();
            }

            _applicationFileTransferRepo.Delete(applicationFileTransfer);
            _globalRepo.Save();
            return Ok(applicationFileTransfer);
        }
    }
}
