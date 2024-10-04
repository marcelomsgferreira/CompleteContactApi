namespace App.Domain.Entities;

public class Group
{
    // [Key]
    public int Id { get; set; }   

    // [Required(ErrorMessage = "Group name is required.")]
    // [StringLength(50, ErrorMessage = "Group name cannot exceed 50 characters.")]
    public string Name { get; set; }   

    // [StringLength(200, ErrorMessage = "Description cannot exceed 200 characters.")]
    public string Description { get; set; }   

    public DateTime CreatedAt { get; set; }   

    public DateTime? UpdatedAt { get; set; }  

    public IList<Contact> Contacts { get; set; } = [];
    
}
