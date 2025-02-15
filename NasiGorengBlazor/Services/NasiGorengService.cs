namespace NasiGorengBlazor.Services
{
    using Microsoft.EntityFrameworkCore;
    using NasiGorengBlazor.Models;

    public class NasiGorengService
    {
        private readonly ApplicationDbContext _context;

        public NasiGorengService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<NasiGoreng>> GetAllAsync()
        {
            return await _context.NasiGorengs.ToListAsync();
        }

        public async Task AddAsync(NasiGoreng nasiGoreng)
        {
            _context.NasiGorengs.Add(nasiGoreng);
            await _context.SaveChangesAsync();
        }
    }

}
