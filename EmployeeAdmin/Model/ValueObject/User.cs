namespace EmployeeAdmin.Model.ValueObject;

public class User
{
    public int Id { get; set; }
    
    public string Username { get; set; }
    
    public string First { get; set; }
    
    public string Last { get; set; }
    
    public string Email { get; set; }
    
    public Department Department { get; set; }
    
    public IList<Role> Roles { get; set; }
    
}