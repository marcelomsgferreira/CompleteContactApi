using App.Dtos;
using App.Domain.Entities;


namespace App.Mappers;

public static class ContactMappers
{
    public static Contact CreateDtoToEntity(this CreateContactDto dto)
    {
        return new Contact()
        {
            FirstName = dto.FirstName,
            LastName = dto.LastName,
            Email = dto.Email,
            Phone = dto.Phone,
            DateOfBirth = dto.DateOfBirth,
            CreatedAt = DateTime.Now,
            UpdatedAt = null,
            AddressId = dto.AddressId
        };
    }
    
    public static Contact UpdateDtoToEntity(this UpdateContactDto dto, int id)
    {
        return new Contact()
        {
            Id = id,
            FirstName = dto.FirstName,
            LastName = dto.LastName,
            Email = dto.Email,
            Phone = dto.Phone,
            DateOfBirth = dto.DateOfBirth,
            UpdatedAt = DateTime.Now,
            AddressId = dto.AddressId
        };
    }

    public static DisplayContactDto EntityToShowDto(this Contact entity)
    {
        return new DisplayContactDto()
        {
            FirstName = entity.FirstName,
            LastName = entity.LastName,
            Email = entity.Email,
            Phone = entity.Phone,
            DateOfBirth = entity.DateOfBirth,
            CreatedAt = entity.CreatedAt,
            UpdatedAt = entity.UpdatedAt,
            AddressId = entity.AddressId
        };
    }

}
