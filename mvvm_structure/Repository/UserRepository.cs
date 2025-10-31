using Microsoft.EntityFrameworkCore;
using mvvm_structure.ApplicationDbContext;
using mvvm_structure.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvvm_structure.Repository
{
    class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task Create(MainModel model)
        {
            await _context.mainModels.AddAsync(model);

            await _context.SaveChangesAsync();

        }

        public async Task Delete(int id)
        {
            var user = await GetByIdAsync(id);

            if (user != null)
            {
                _context.mainModels.Remove(user);

                await _context.SaveChangesAsync();
            }

        }

        public async Task<List<MainModel>> GetAll()
        {
            var users = await _context.mainModels.AsNoTracking().ToListAsync();

            return users;

        }

        public async Task<MainModel> GetByIdAsync(int id)
        {
            var user = await _context.mainModels.FindAsync(id);
            return user;
        }

        public async Task Update(MainModel model)
        {
            _context.mainModels.Update(model);

            await _context.SaveChangesAsync();
        }
    }
}
