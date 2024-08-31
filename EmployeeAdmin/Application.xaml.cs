namespace EmployeeAdmin;

public partial class Application : Microsoft.Maui.Controls.Application
{
    public Application()
    {
        InitializeComponent();

        ApplicationFacade.GetInstance(ApplicationFacade.KEY).Startup();
        
        MainPage = new AppShell();
    }
}