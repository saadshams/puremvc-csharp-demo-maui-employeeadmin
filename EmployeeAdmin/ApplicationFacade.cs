using EmployeeAdmin.Controller;
using PureMVC.Patterns.Facade;

namespace EmployeeAdmin;

public class ApplicationFacade(string key) : Facade(key)
{
    protected override void InitializeController()
    {
        base.InitializeController();
        RegisterCommand(STARTUP, () => new StartupCommand());
    }

    public static ApplicationFacade GetInstance(string key)
    {
        return (Facade.GetInstance(key, k => new ApplicationFacade(k)) as ApplicationFacade)!;
    }

    public void Startup()
    {
        SendNotification(STARTUP);
    }

    public const string KEY = "ApplicationFacade";
    
    public const string STARTUP = "startup";
}