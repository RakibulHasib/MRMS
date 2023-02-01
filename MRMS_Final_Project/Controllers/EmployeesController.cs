using Microsoft.AspNetCore.Mvc;
using MRMS.DAL;
using MRMS.Model.EmployeeSection;
using MRMS_Final_Project.ViewModels;

namespace MRMS_Final_Project.Controllers
{
    //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]

    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private IGlobalRepository _globalRepository;
        private IGenericRepository<Employee> _employeeRepository;
        private readonly IWebHostEnvironment _env;

        public EmployeesController(IGlobalRepository globalRepository, IWebHostEnvironment env)
        {
            this._globalRepository = globalRepository;
            this._employeeRepository = _globalRepository.EmployeeRepository;
            _env = env;
        }

        [HttpGet]
        public IEnumerable<Employee> GetEmployees()
        {
            return _employeeRepository.GetAll();
        }
        [HttpPost]
        public ActionResult EmployeePost([FromForm] EmployeeVM employeeVM)
        {
            if (employeeVM == null)
            {
                return NotFound();
            }
            try
            {
                Employee employee = new Employee()
                {
                    Name = employeeVM.Name,
                    FathersName = employeeVM.FathersName,
                    MothersName = employeeVM.MothersName,
                    Spouse = employeeVM.Spouse,
                    PresentAddress = employeeVM.PresentAddress,
                    PermanentAddress = employeeVM.PermanentAddress,
                    DateOfBrith = employeeVM.DateOfBrith,
                    PhoneNumber = employeeVM.PhoneNumber,
                    NID = employeeVM.NID,
                    BirthCertificateNo = employeeVM.BirthCertificateNo,
                    Email = employeeVM.Email,
                    Nationality = employeeVM.Nationality,
                    Gender = employeeVM.Gender,
                    Religion = employeeVM.Religion,
                    MaritalStatus = employeeVM.MaritalStatus,
                    Education = employeeVM.Education,
                    DesignationId = employeeVM.DesignationId
                };
                string path = _env.WebRootPath + "\\Uploads\\";
                string ext = Path.GetExtension(employeeVM.Image.FileName);
                string f = Guid.NewGuid() + ext;
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                using FileStream fileStream = System.IO.File.Create(path + f);
                employeeVM.Image.CopyTo(fileStream);
                fileStream.Flush();
                employee.Picture = f;
                fileStream.Close();
                _employeeRepository.Insert(employee);
                _globalRepository.Save();
                return Ok(employee);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [HttpPut]
        public ActionResult EmployeeUpdate([FromForm] EmployeeVM employeeVM)
        {
            if (employeeVM == null)
            {
                return NotFound();
            }


            if (employeeVM == null)
            {
                return NotFound();
            }
            try
            {
                Employee employee = new Employee()
                {
                    EmployeeId = employeeVM.EmployeeId,
                    Name = employeeVM.Name,
                    FathersName = employeeVM.FathersName,
                    MothersName = employeeVM.MothersName,
                    Spouse = employeeVM.Spouse,
                    PresentAddress = employeeVM.PresentAddress,
                    PermanentAddress = employeeVM.PermanentAddress,
                    DateOfBrith = employeeVM.DateOfBrith,
                    PhoneNumber = employeeVM.PhoneNumber,
                    NID = employeeVM.NID,
                    BirthCertificateNo = employeeVM.BirthCertificateNo,
                    Email = employeeVM.Email,
                    Nationality = employeeVM.Nationality,
                    Gender = employeeVM.Gender,
                    Religion = employeeVM.Religion,
                    MaritalStatus = employeeVM.MaritalStatus,
                    Education = employeeVM.Education,
                    DesignationId = employeeVM.DesignationId
                };
                string path = _env.WebRootPath + "\\Uploads\\";
                string ext = Path.GetExtension(employeeVM.Image.FileName);
                string f = Guid.NewGuid() + ext;
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                using FileStream fileStream = System.IO.File.Create(path + f);
                employeeVM.Image.CopyTo(fileStream);
                fileStream.Flush();
                employee.Picture = f;
                fileStream.Close();
                _employeeRepository.Update(employee);
                _globalRepository.Save();
                return Ok(employee);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }




        }

        [HttpDelete("{id}")]
        public ActionResult DeleteEmployee(int id)
        {
            var employee = _employeeRepository.Get(id);
            if (employee == null)
            {
                return NotFound();
            }
            _employeeRepository.Delete(employee);
            _globalRepository.Save();
            return NoContent();
    }


    }
}



// else
//{
//    if (employeeVM.Image != null)
//    {
//        try
//        {
//            Employee employee = new Employee()
//            {
//                EmployeeId = employeeVM.EmployeeId,
//                Name = employeeVM.Name,
//                FathersName = employeeVM.FathersName,
//                MothersName = employeeVM.MothersName,
//                Spouse = employeeVM.Spouse,
//                PresentAddress = employeeVM.PresentAddress,
//                PermanentAddress = employeeVM.PermanentAddress,
//                DateOfBrith = employeeVM.DateOfBrith,
//                PhoneNumber = employeeVM.PhoneNumber,
//                NID = employeeVM.NID,
//                BirthCertificateNo = employeeVM.BirthCertificateNo,
//                Email = employeeVM.Email,
//                Nationality = employeeVM.Nationality,
//                Gender = employeeVM.Gender,
//                Religion = employeeVM.Religion,
//                MaritalStatus = employeeVM.MaritalStatus,
//                Education = employeeVM.Education,
//                DesignationId = employeeVM.DesignationId
//            };
//            string path = _env.WebRootPath + "\\Uploads\\";
//            string ext = Path.GetExtension(employeeVM.Image.FileName);
//            string f = Guid.NewGuid() + ext;
//            if (!Directory.Exists(path))
//            {
//                Directory.CreateDirectory(path);
//            }
//            using FileStream fileStream = System.IO.File.Create(path + f);
//            employeeVM.Image.CopyTo(fileStream);
//            fileStream.Flush();
//            employee.Picture = f;
//            fileStream.Close();
//            _employeeRepository.Update(employee);
//            _globalRepository.Save();
//            return Ok();
//        }
//        catch (Exception ex)
//        {

//            return BadRequest(ex.Message);
//        }

//    }
//    else
//    {
//        Employee employee = new Employee()
//        {
//            EmployeeId = employeeVM.EmployeeId,
//            Name = employeeVM.Name,
//            FathersName = employeeVM.FathersName,
//            MothersName = employeeVM.MothersName,
//            Spouse = employeeVM.Spouse,
//            PresentAddress = employeeVM.PresentAddress,
//            PermanentAddress = employeeVM.PermanentAddress,
//            DateOfBrith = employeeVM.DateOfBrith,
//            PhoneNumber = employeeVM.PhoneNumber,
//            NID = employeeVM.NID,
//            BirthCertificateNo = employeeVM.BirthCertificateNo,
//            Email = employeeVM.Email,
//            Nationality = employeeVM.Nationality,
//            Gender = employeeVM.Gender,
//            Religion = employeeVM.Religion,
//            MaritalStatus = employeeVM.MaritalStatus,
//            Education = employeeVM.Education,
//            Picture = employeeVM.Picture,
//        };
//        _employeeRepository.Update(employee);
//        _globalRepository.Save();
//        return Ok();

//    }
