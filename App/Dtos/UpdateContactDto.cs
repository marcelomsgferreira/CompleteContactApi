namespace App.Dtos;

public class UpdateContactDto
{    
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public DateTime DateOfBirth { get; set; }
    public int AddressId { get; set; }
}
