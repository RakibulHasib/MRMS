using Microsoft.AspNetCore.Mvc;
using MRMS.DAL;
using MRMS.Model.MedicalSection;

[Route("api/[controller]")]
[ApiController]
public class MedicalCentersController : ControllerBase
{
    private IGlobalRepository _globalRepo;
    private IGenericRepository<MedicalCenter> _medicalRepo;

    public MedicalCentersController(IGlobalRepository globalRepository)
    {
        this._globalRepo = globalRepository;
        this._medicalRepo = _globalRepo.MedicalCenterRepository;
    }

    // GET: api/MedicalCenters

    [HttpGet]
    public IEnumerable<MedicalCenter> GetMedicalCenters()
    {
        return _medicalRepo.GetAll();
    }

    //Insert Medical Center
    [HttpPost]
    public ActionResult MedicalCentersPost(MedicalCenter medicalCenters)
    {
        _medicalRepo.Insert(medicalCenters);
        _globalRepo.Save();
        return Ok(medicalCenters);
    }

    //Update Medical Center
    [HttpPut("{id}")]
    public IActionResult UpdateMedicalCenter(MedicalCenter medicalCenter)
    {
        if (medicalCenter.MedicalCenterId == 0)
        {
            return NotFound();
        }

        _medicalRepo.Update(medicalCenter);
        _globalRepo.Save();
        return Ok(medicalCenter);
    }


    //Delete Medical Center
    [HttpDelete("{id}")]
    public IActionResult DeleteMedicalCenter(int id)
    {
        MedicalCenter medicalCenter = _medicalRepo.Get(id);
        if (medicalCenter == null)
        {
            return NotFound();
        }
        _medicalRepo.Delete(medicalCenter);
        _globalRepo.Save();
        return Ok(medicalCenter);
    }
}