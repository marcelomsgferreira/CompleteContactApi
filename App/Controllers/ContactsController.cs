using App.Database;
using App.Domain.Interfaces;
using App.Dtos;
using App.Domain.Entities;
using App.Mappers;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers;

[ApiController]
[Route("api/contacts")]
public class ContactsController : ControllerBase
{
 private readonly IRepository<Contact> _repository;

        public ContactsController(IRepository<Contact> repository)
        {
            _repository = repository;
        }

        // GET: api/contacts
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<Contact>>> GetAllContacts()
        {
            var contacts = await _repository.GetAllAsync();
            return Ok(contacts);
        }

        // GET: api/contacts/5
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<Contact>> GetContactById(int id)
        {
            var contact = await _repository.GetByIdAsync(id);
            if (contact == null)
            {
                return NotFound();
            }
            return Ok(contact);
        }

        // POST: api/contacts
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Contact>> CreateContact(CreateContactDto contactDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            
            var contact = contactDto.CreateDtoToEntity();
            var createdProduct = await _repository.AddAsync(contact);
            await _repository.Commit();            
            return CreatedAtAction(nameof(GetContactById), new { id = createdProduct.Id }, createdProduct);
        }

        // PUT: api/contacts/5
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> UpdateContact(int id, UpdateContactDto contactDto)
        {

            var existingContact = await _repository.GetByIdAsync(id);
            if (existingContact == null)
            {
                return NotFound();
            }

            existingContact.FirstName = contactDto.FirstName;
            existingContact.LastName = contactDto.LastName;
            existingContact.Phone = contactDto.Phone;
            existingContact.Email = contactDto.Email;
            existingContact.DateOfBirth = contactDto.DateOfBirth;
            existingContact.AddressId = contactDto.AddressId;

            await _repository.Commit();

            return Ok();
        }

        // DELETE: api/contacts/5
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> DeleteContact(int id)
        {
            var contact = await _repository.GetByIdAsync(id);
            if (contact == null)
            {
                return NotFound();
            }

            await _repository.RemoveAsync(contact);
            await _repository.Commit();            
            return NoContent();
        }

}
