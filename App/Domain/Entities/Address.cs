namespace App.Domain.Entities;

public class Address
{
    [Key]
    public int Id { get; set; }  

    [Required(ErrorMessage = "Street is required.")]
    [StringLength(100, ErrorMessage = "Street cannot exceed 100 characters.")]
    public string Street { get; set; }  

    [Required(ErrorMessage = "City is required.")]
    [StringLength(50, ErrorMessage = "City cannot exceed 50 characters.")]
    public string City { get; set; }  

    [Required(ErrorMessage = "State is required.")]
    [StringLength(50, ErrorMessage = "State cannot exceed 50 characters.")]
    public string State { get; set; }  

    [Required(ErrorMessage = "Postal code is required.")]
    [StringLength(20, ErrorMessage = "Postal code cannot exceed 20 characters.")]
    public string PostalCode { get; set; }  
    [Required(ErrorMessage = "Country is required.")]
    [StringLength(50, ErrorMessage = "Country cannot exceed 50 characters.")]
    public string Country { get; set; }  

    [StringLength(50, ErrorMessage = "Address type cannot exceed 50 characters.")]
    public string AddressType { get; set; }  

    public DateTime CreatedAt { get; set; }  

    public DateTime? UpdatedAt { get; set; } 
    public ICollection<Contact> Contacts { get; set;}
}
