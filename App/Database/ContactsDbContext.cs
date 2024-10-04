namespace App.Database;

public class ContactsDbContext : DbContext
{

    public ContactsDbContext(DbContextOptions options) : base(options)
    {

    }

    public DbSet<Contact> Contacts { get; set; }
    public DbSet<Address> Addresses { get; set; }
    public DbSet<Group> ContactsGroup { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {

        builder.Entity<Address>().HasData(
            new Address
            {
                Id = 1,
                Street = "123 Main Street",
                City = "New York",
                State = "NY",
                PostalCode = "10001",
                Country = "USA",
                AddressType = "Home",
                CreatedAt = DateTime.Now,
                UpdatedAt = null,
                Contacts = new List<Contact>() // Inicialmente sem contatos associados.
            },
            new Address
            {
                Id = 2,
                Street = "456 Oak Avenue",
                City = "Los Angeles",
                State = "CA",
                PostalCode = "90001",
                Country = "USA",
                AddressType = "Work",
                CreatedAt = DateTime.Now,
                UpdatedAt = null,
                Contacts = new List<Contact>()
            },
            new Address
            {
                Id = 3,
                Street = "789 Pine Road",
                City = "Chicago",
                State = "IL",
                PostalCode = "60601",
                Country = "USA",
                AddressType = "Billing",
                CreatedAt = DateTime.Now,
                UpdatedAt = null,
                Contacts = new List<Contact>()
            });
        builder.Entity<Group>().HasData(
            new Group
            {
                Id = 1,
                Name = "Family",
                Description = "Family members and relatives",
                CreatedAt = DateTime.Now,
                UpdatedAt = null,
                Contacts = new List<Contact>() // Inicialmente sem contatos associados.
            },
            new Group
            {
                Id = 2,
                Name = "Friends",
                Description = "Close and personal friends",
                CreatedAt = DateTime.Now,
                UpdatedAt = null,
                Contacts = new List<Contact>()
            },
            new Group
            {
                Id = 3,
                Name = "Work",
                Description = "Colleagues from work",
                CreatedAt = DateTime.Now,
                UpdatedAt = null,
                Contacts = new List<Contact>()
            },
            new Group
            {
                Id = 4,
                Name = "Clients",
                Description = "Business clients and partners",
                CreatedAt = DateTime.Now,
                UpdatedAt = null,
                Contacts = new List<Contact>()
            },
            new Group
            {
                Id = 5,
                Name = "Suppliers",
                Description = "Suppliers and vendors for business",
                CreatedAt = DateTime.Now,
                UpdatedAt = null,
                Contacts = new List<Contact>()
            });
        builder.Entity<Contact>().HasData(
            new Contact
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe",
                Email = "john.doe@example.com",
                Phone = "(123) 456-7890",
                
                DateOfBirth = new DateTime(1990, 5, 12),
                CreatedAt = DateTime.Now,
                UpdatedAt = null,
                AddressId = 1, 
            },
            new Contact
            {
                Id = 2,
                FirstName = "Jane",
                LastName = "Smith",
                Email = "jane.smith@example.com",
                Phone = "(234) 567-8901",
                DateOfBirth = new DateTime(1985, 11, 23),
                CreatedAt = DateTime.Now,
                UpdatedAt = null,
                AddressId = 2,
                               
            },
            new Contact
            {
                Id = 3,
                FirstName = "Michael",
                LastName = "Brown",
                Email = "michael.brown@example.com",
                Phone = "(345) 678-9012",
                DateOfBirth = new DateTime(1995, 8, 14),
                CreatedAt = DateTime.Now,
                UpdatedAt = null,
                AddressId = 3,
                               
            },
            new Contact
            {
                Id = 4,
                FirstName = "Emily",
                LastName = "Davis",
                Email = "emily.davis@example.com",
                Phone = "(456) 789-0123",
                DateOfBirth = new DateTime(1992, 7, 8),
                CreatedAt = DateTime.Now,
                UpdatedAt = null,
                AddressId = 1,
                               
            },
            new Contact
            {
                Id = 5,
                FirstName = "David",
                LastName = "Miller",
                Email = "david.miller@example.com",
                Phone = "(567) 890-1234",
                DateOfBirth = new DateTime(1987, 3, 16),
                CreatedAt = DateTime.Now,
                UpdatedAt = null,
                AddressId = 2,
                               
            },
            new Contact
            {
                Id = 6,
                FirstName = "Sarah",
                LastName = "Wilson",
                Email = "sarah.wilson@example.com",
                Phone = "(678) 901-2345",
                DateOfBirth = new DateTime(1993, 4, 5),
                CreatedAt = DateTime.Now,
                UpdatedAt = null,
                AddressId = 3,
                               
            },
            new Contact
            {
                Id = 7,
                FirstName = "Christopher",
                LastName = "Moore",
                Email = "christopher.moore@example.com",
                Phone = "(789) 012-3456",
                DateOfBirth = new DateTime(1989, 2, 28),
                CreatedAt = DateTime.Now,
                UpdatedAt = null,
                AddressId = 1,
                               
            });

    }

}
