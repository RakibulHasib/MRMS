using MRMS.Model.Authentication;


namespace MRMS_Final_Project.Services
{
    public interface IAuthenticateService
    {
        User Authenticate(string username, string password);
    }
}
