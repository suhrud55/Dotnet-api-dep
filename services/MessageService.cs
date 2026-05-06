using MyEnterpriseApp.Models;

namespace MyEnterpriseApp.Services
{
    public class MessageService : IMessageService
    {
        public AppInfo GetAppInfo()
        {
            return new AppInfo
            {
                AppName = "Enterprise Azure DevOps App",
                Version = "1.0.0",
                Environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "Unknown"
            };
        }
    }
}
