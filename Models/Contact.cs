namespace Addressbook.Models;

public interface IContact
{
    string Address { get; set; }
    string Email { get; set; }
    string FirstName { get; set; }
    string LastName { get; set; }
    int Phone { get; set; }
}

public class Contact : IContact
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public int Phone { get; set; }
    public string Email { get; set; } = null!;
    public string Address { get; set; } = null!;

}
