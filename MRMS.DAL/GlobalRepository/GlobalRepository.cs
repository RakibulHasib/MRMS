using MRMS.DAL.Context;
using MRMS.Model.AgencySection;
using MRMS.Model.ApplicantSection;
using MRMS.Model.ApplicationSection;
using MRMS.Model.CallingSection;
using MRMS.Model.CommonSection;
using MRMS.Model.DemandSection;
using MRMS.Model.EmployeeSection;
using MRMS.Model.FlightSection;
using MRMS.Model.ForwardingSection;
using MRMS.Model.MedicalSection;
using MRMS.Model.RejectSection;
using MRMS.Model.VisaSection;

namespace MRMS.DAL
{
    public class GlobalRepository : IGlobalRepository, IDisposable
    {
        private MRMSDBContext _context;

        //FileType
        private IGenericRepository<FileType>? _fileTypeRepo;

        //Country
        private IGenericRepository<Country>? _countryRepo;

        //Company
        private IGenericRepository<Company>? _companyRepo;

        //Agency
        private IGenericRepository<Agency>? _agencyRepo;
        private IGenericRepository<AgencySyndicate>? _agencySyndicateRepo;

        //Agent
        private IGenericRepository<Agent>? _agentRepo;

        //Demand
        private IGenericRepository<Demand>? _demandRepo;
        private IGenericRepository<DemandFile>? _demandFileRepo;
        private IGenericRepository<DemandIssue>? _demandIssueRepo;
        private IGenericRepository<Trade>? _tradeRepo;

        //Applicant
        private IGenericRepository<Applicant>? _applicantRepo;
        private IGenericRepository<ApplicantFile>? _applicantFileRepo;
        private IGenericRepository<ApplicantIssue>? _applicantIssueRepo;

        //Medical
        private IGenericRepository<MedicalCenter>? _medicalCenterRepo;
        private IGenericRepository<MedicalRecord>? _medicalRecordRepo;
        private IGenericRepository<MedicalFile>? _medicalFileRepo;
        private IGenericRepository<MedicalIssue>? _medicalIssueRepo;

        //Application
        private IGenericRepository<Application>? _applicationRepo;
        private IGenericRepository<ApplicationFile>? _applicationFileRepo;
        private IGenericRepository<ApplicationFileTransfer>? _applicationFileTransferRepo;
        private IGenericRepository<ApplicationIssue>? _applicationIssueRepo;

        //Calling
        private IGenericRepository<Calling>? _callingRepo;
        private IGenericRepository<CallingFile>? _callingFileRepo;
        private IGenericRepository<CallingIssue>? _callingIssueRepo;

        //Forwarding

        private IGenericRepository<Forwarding>? _forwardingRepo;
        private IGenericRepository<ForwardingFile>? _forwardingFileRepo;
        private IGenericRepository<ForwardingFileTransfer>? _forwardingFileTransferRepo;
        private IGenericRepository<ForwardingIssue>? _forwardingIssueRepo;
        private IGenericRepository<TrainingCentre>? _trainingCentreRepo;
        private IGenericRepository<BMET>? _BMETRepo;
        private IGenericRepository<Training>? _trainingRepo;
        private IGenericRepository<FingerPrint>? _fingerPrintRepo;

        //Visa
        private IGenericRepository<Visa>? _visaRepo;
        private IGenericRepository<VisaFile>? _visaFileRepo;
        private IGenericRepository<VisaFileTransfer>? _visaFileTransferRepo;
        private IGenericRepository<VisaIssue>? _visaIssueRepo;

        //Flight
        private IGenericRepository<Flight>? _flightRepo;
        private IGenericRepository<FlightFile>? _flightFileRepo;
        private IGenericRepository<FlightIssue>? _flightIssueRepo;

        //Rejected Applicant
        private IGenericRepository<RejectedApplicant>? _rejectedApplicantRepo;

        //Designation
        private IGenericRepository<Designation>? _designationRepo;

        //Employee
        private IGenericRepository<Employee>? _employeeRepo;
        private IGenericRepository<EmployeeFile>? _employeeFileRepo;


        //Constructor
        public GlobalRepository(MRMSDBContext _context)
        {
            this._context = _context;
        }


        public IGenericRepository<FileType> FileTypeRepository
        {
            get
            {
                if (_fileTypeRepo == null)
                {
                    _fileTypeRepo = new GenericRepository<FileType>(_context);
                }
                return _fileTypeRepo;

            }
        }


        public IGenericRepository<Applicant> ApplicantRepository
        {
            get
            {
                if (_applicantRepo == null)
                {
                    _applicantRepo = new GenericRepository<Applicant>(_context);
                }
                return _applicantRepo;
            }
        }

        public IGenericRepository<Application> ApplicationRepository
        {
            get
            {
                if (_applicationRepo == null)
                {
                    _applicationRepo = new GenericRepository<Application>(_context);
                }
                return _applicationRepo;
            }
        }

        public IGenericRepository<Demand> DemandRepository
        {
            get
            {
                if (_demandRepo == null)
                {
                    _demandRepo = new GenericRepository<Demand>(_context);
                }
                return _demandRepo;
            }
        }

        public IGenericRepository<DemandFile> DemandFileRepository
        {
            get
            {
                if (_demandFileRepo == null)
                {
                    _demandFileRepo = new GenericRepository<DemandFile>(_context);
                }
                return _demandFileRepo;
            }
        }

        public IGenericRepository<DemandIssue> DemandIssueRepository
        {
            get
            {
                if (_demandIssueRepo == null)
                {
                    _demandIssueRepo = new GenericRepository<DemandIssue>(_context);
                }
                return _demandIssueRepo;
            }
        }

        public IGenericRepository<ApplicantFile> ApplicantFileRepository
        {
            get
            {
                if (_applicantFileRepo == null)
                {
                    _applicantFileRepo = new GenericRepository<ApplicantFile>(_context);
                }
                return _applicantFileRepo;
            }
        }

        public IGenericRepository<ApplicantIssue> ApplicantIssueRepository
        {
            get
            {
                if (_applicantIssueRepo == null)
                {
                    _applicantIssueRepo = new GenericRepository<ApplicantIssue>(_context);
                }
                return _applicantIssueRepo;
            }
        }

        public IGenericRepository<MedicalCenter> MedicalCenterRepository
        {
            get
            {
                if (_medicalCenterRepo == null)
                {
                    _medicalCenterRepo = new GenericRepository<MedicalCenter>(_context);
                }
                return _medicalCenterRepo;
            }
        }

        public IGenericRepository<MedicalRecord> MedicalRecordRepository
        {
            get
            {
                if (_medicalRecordRepo == null)
                {
                    _medicalRecordRepo = new GenericRepository<MedicalRecord>(_context);
                }
                return _medicalRecordRepo;
            }
        }

        public IGenericRepository<MedicalFile> MedicalFileRepository
        {
            get
            {
                if (_medicalFileRepo == null)
                {
                    _medicalFileRepo = new GenericRepository<MedicalFile>(_context);
                }
                return _medicalFileRepo;
            }
        }

        public IGenericRepository<MedicalIssue> MedicalIssueRepository
        {
            get
            {
                if (_medicalIssueRepo == null)
                {
                    _medicalIssueRepo = new GenericRepository<MedicalIssue>(_context);
                }
                return _medicalIssueRepo;
            }
        }

        public IGenericRepository<ApplicationFile> ApplicationFileRepository
        {
            get
            {
                if (_applicationFileRepo == null)
                {
                    _applicationFileRepo = new GenericRepository<ApplicationFile>(_context);
                }
                return _applicationFileRepo;
            }
        }

        public IGenericRepository<ApplicationFileTransfer> ApplicationFileTransferRepository
        {
            get
            {
                if (_applicationFileTransferRepo == null)
                {
                    _applicationFileTransferRepo = new GenericRepository<ApplicationFileTransfer>(_context);
                }
                return _applicationFileTransferRepo;
            }
        }

        public IGenericRepository<ApplicationIssue> ApplicationIssueRepository
        {
            get
            {
                if (_applicationIssueRepo == null)
                {
                    _applicationIssueRepo = new GenericRepository<ApplicationIssue>(_context);
                }
                return _applicationIssueRepo;
            }
        }

        public IGenericRepository<Calling> CallingRepository
        {
            get
            {
                if (_callingRepo == null)
                {
                    _callingRepo = new GenericRepository<Calling>(_context);
                }
                return _callingRepo;
            }
        }

        public IGenericRepository<CallingFile> CallingFileRepository
        {
            get
            {
                if (_callingFileRepo == null)
                {
                    _callingFileRepo = new GenericRepository<CallingFile>(_context);
                }
                return _callingFileRepo;
            }
        }

        public IGenericRepository<CallingIssue> CallingIssueRepository
        {
            get
            {
                if (_callingIssueRepo == null)
                {
                    _callingIssueRepo = new GenericRepository<CallingIssue>(_context);
                }
                return _callingIssueRepo;
            }
        }

        public IGenericRepository<Employee> EmployeeRepository
        {
            get
            {
                if (_employeeRepo == null)
                {
                    _employeeRepo = new GenericRepository<Employee>(_context);
                }
                return _employeeRepo;

            }
        }

        public IGenericRepository<EmployeeFile> EmployeeFileRepository
        {
            get
            {
                if (_employeeFileRepo == null)
                {
                    _employeeFileRepo = new GenericRepository<EmployeeFile>(_context);
                }
                return _employeeFileRepo;

            }
        }

        public IGenericRepository<Country> CountryRepository
        {
            get
            {
                if (_countryRepo == null)
                {
                    _countryRepo = new GenericRepository<Country>(_context);
                }
                return _countryRepo;

            }
        }

        public IGenericRepository<Company> CompanyRepository
        {
            get
            {
                if (_companyRepo == null)
                {
                    _companyRepo = new GenericRepository<Company>(_context);
                }
                return _companyRepo;

            }
        }

        public IGenericRepository<Agent> AgentRepository
        {
            get
            {
                if (_agentRepo == null)
                {
                    _agentRepo = new GenericRepository<Agent>(_context);
                }
                return _agentRepo;

            }
        }

        public IGenericRepository<TrainingCentre> TrainingCenterRepository
        {
            get
            {
                if (_trainingCentreRepo == null)
                {
                    _trainingCentreRepo = new GenericRepository<TrainingCentre>(_context);
                }
                return _trainingCentreRepo;

            }
        }

        public IGenericRepository<Agency> AgencyRepository
        {
            get
            {
                if (_agencyRepo == null)
                {
                    _agencyRepo = new GenericRepository<Agency>(_context);
                }
                return _agencyRepo;

            }
        }

        public IGenericRepository<AgencySyndicate> AgencySyndicateRepository
        {
            get
            {
                if (_agencySyndicateRepo == null)
                {
                    _agencySyndicateRepo = new GenericRepository<AgencySyndicate>(_context);
                }
                return _agencySyndicateRepo;

            }
        }

        public IGenericRepository<Trade> TradeRepository
        {
            get
            {
                if (_tradeRepo == null)
                {
                    _tradeRepo = new GenericRepository<Trade>(_context);
                }
                return _tradeRepo;
            }
        }

        public IGenericRepository<Forwarding> ForwardingRepository
        {
            get
            {
                if (_forwardingRepo == null)
                {
                    _forwardingRepo = new GenericRepository<Forwarding>(_context);
                }
                return _forwardingRepo;

            }
        }

        public IGenericRepository<ForwardingFile> ForwardingFileRepository
        {
            get
            {
                if (_forwardingFileRepo == null)
                {
                    _forwardingFileRepo = new GenericRepository<ForwardingFile>(_context);
                }
                return _forwardingFileRepo;

            }
        }

        public IGenericRepository<ForwardingIssue> ForwardingIssueRepository
        {
            get
            {
                if (_forwardingIssueRepo == null)
                {
                    _forwardingIssueRepo = new GenericRepository<ForwardingIssue>(_context);
                }
                return _forwardingIssueRepo;

            }
        }

        public IGenericRepository<ForwardingFileTransfer> ForwardingFileTransferRepository
        {
            get
            {
                if (_forwardingFileTransferRepo == null)
                {
                    _forwardingFileTransferRepo = new GenericRepository<ForwardingFileTransfer>(_context);
                }
                return _forwardingFileTransferRepo;

            }
        }

        public IGenericRepository<BMET> BMETRepository
        {
            get
            {
                if (_BMETRepo == null)
                {
                    _BMETRepo = new GenericRepository<BMET>(_context);
                }
                return _BMETRepo;

            }
        }

        public IGenericRepository<Training> TrainingRepository
        {
            get
            {
                if (_trainingRepo == null)
                {
                    _trainingRepo = new GenericRepository<Training>(_context);
                }
                return _trainingRepo;

            }
        }

        public IGenericRepository<FingerPrint> FingerPrintRepository
        {
            get
            {
                if (_fingerPrintRepo == null)
                {
                    _fingerPrintRepo = new GenericRepository<FingerPrint>(_context);
                }
                return _fingerPrintRepo;

            }
        }

        public IGenericRepository<Visa> VisaRepository
        {
            get
            {
                if (_visaRepo == null)
                {
                    _visaRepo = new GenericRepository<Visa>(_context);
                }
                return _visaRepo;

            }
        }

        public IGenericRepository<VisaFile> VisaFileRepository
        {
            get
            {
                if (_visaFileRepo == null)
                {
                    _visaFileRepo = new GenericRepository<VisaFile>(_context);
                }
                return _visaFileRepo;

            }
        }

        public IGenericRepository<VisaIssue> VisaIssueRepository
        {
            get
            {
                if (_visaIssueRepo == null)
                {
                    _visaIssueRepo = new GenericRepository<VisaIssue>(_context);
                }
                return _visaIssueRepo;

            }
        }

        public IGenericRepository<VisaFileTransfer> VisaFileTransferRepository
        {
            get
            {
                if (_visaFileTransferRepo == null)
                {
                    _visaFileTransferRepo = new GenericRepository<VisaFileTransfer>(_context);
                }
                return _visaFileTransferRepo;

            }
        }

        public IGenericRepository<Flight> FlightRepository
        {
            get
            {
                if (_flightRepo == null)
                {
                    _flightRepo = new GenericRepository<Flight>(_context);
                }
                return _flightRepo;

            }
        }

        public IGenericRepository<FlightFile> FlightFileRepository
        {
            get
            {
                if (_flightFileRepo == null)
                {
                    _flightFileRepo = new GenericRepository<FlightFile>(_context);
                }
                return _flightFileRepo;

            }
        }

        public IGenericRepository<FlightIssue> FlightIssueRepository
        {
            get
            {
                if (_flightIssueRepo == null)
                {
                    _flightIssueRepo = new GenericRepository<FlightIssue>(_context);
                }
                return _flightIssueRepo;

            }
        }

        public IGenericRepository<RejectedApplicant> RejectedApplicantRepository
        {
            get
            {
                if (_rejectedApplicantRepo == null)
                {
                    _rejectedApplicantRepo = new GenericRepository<RejectedApplicant>(_context);
                }
                return _rejectedApplicantRepo;

            }
        }

        public IGenericRepository<Designation> DesignationRepository
        {
            get
            {
                if (_designationRepo == null)
                {
                    _designationRepo = new GenericRepository<Designation>(_context);
                }
                return _designationRepo;
            }
        }


        //--------------------------------------------------------

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);

            GC.SuppressFinalize(this);
        }

        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }
    }
}
