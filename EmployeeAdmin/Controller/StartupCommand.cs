using EmployeeAdmin.Model;
using EmployeeAdmin.View;
using PureMVC.Interfaces;
using PureMVC.Patterns.Command;

namespace EmployeeAdmin.Controller;

public class StartupCommand: SimpleCommand
{
    public override void Execute(INotification notification)
    {
        var userProxy = new UserProxy();
        Facade.RegisterProxy(userProxy);
        Facade.RegisterProxy(new RoleProxy());
        Facade.RegisterMediator(new EmployeeAdminMediator());
    }
}