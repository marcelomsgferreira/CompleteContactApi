using System.Linq.Expressions;
using App.Database;
using App.Repositories.Abstractions;

namespace App.Repositories;

public class ContactRepository : IRepository<Contact>, IUnitOfWork
{
    protected readonly ContactsDbContext _context;

    public ContactRepository(ContactsDbContext context)
    {
        _context = context;
    }

    public async Task<Contact> AddAsync(Contact entity)
    {
        await _context.Set<Contact>().AddAsync(entity);
        return entity;
    }

    public async Task<IEnumerable<Contact>> AddRangeAsync(IEnumerable<Contact> entities)
    {
        await _context.Set<Contact>().AddRangeAsync(entities);
        return entities;
    }

    public async Task<Contact> GetByIdAsync(int id)
    {
        return await _context.Set<Contact>().FindAsync(id);
    }

    public async Task<IEnumerable<Contact>> GetAllAsync()
    {
        return await _context.Set<Contact>().ToListAsync();
    }

    public async Task<IEnumerable<Contact>> FindAsync(Expression<Func<Contact, bool>> predicate)
    {
        return await _context.Set<Contact>().Where(predicate).ToListAsync();
    }

    public async Task RemoveAsync(Contact entity)
    {
        _context.Set<Contact>().Remove(entity);
    }

    public async Task RemoveRangeAsync(IEnumerable<Contact> entities)
    {
        _context.Set<Contact>().RemoveRange(entities);
    }

    public async Task<bool> Commit()
    {
        return await _context.SaveChangesAsync() > 0;
    }

    public Task Rollback()
    {
        return Task.CompletedTask;
    }

}
