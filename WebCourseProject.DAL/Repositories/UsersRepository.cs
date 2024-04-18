using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebCourseProject.Domain.Entities;

namespace WebCourseProject.DAL.Repositories
{
    
    public class UsersRepository
    {
        private readonly AppDbContext _dbContext;
        public UsersRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task <List<Users>?> GetALl()
        {
            return await _dbContext.Users
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<Users?> GetById(int userId)
        {
            return await _dbContext.Users
                .AsNoTracking()
                .FirstOrDefaultAsync(user => user.userId == userId);
        }

        public async Task<List<Users>?> GetWithRole()
        {
            return await _dbContext.Users
                .AsNoTracking()
                .Include(user => user.Role)
                .ToListAsync();
        }

        public async Task<List<Users>?> GetWithNameFilter(string name)
        {
            var query = _dbContext.Users.AsNoTracking();

            if (!string.IsNullOrEmpty(name))
            {
                query = query.Where(user => user.name.Contains(name));
            }
            return await query
                .ToListAsync();
        }

        public async Task<List<Users>?> GetByPage(int page_number, int page_size)
        {

            return await _dbContext.Users
                .AsNoTracking()
                .Skip((page_number-1)*page_size)
                .Take(page_size)
                .ToListAsync();
        }

        public async Task Get(int userId, string name, string login, string password)
        {
            var User = new Users
            {
                userId = userId,
                name = name,
                login = login,
                password = password
            };

            await _dbContext.AddAsync(User);
            await _dbContext.SaveChangesAsync();
        }

        /*        public async Task Update(int userId, string name, string login, string password)
                {
                    await _dbContext.Users
                        .Where(user => user.userId == userId)
                        .ExecuteUpdateAsync(update => update
                        .SetProperty(user => user.name, name)
                        .SetProperty(user => user.login, login)
                        .SetProperty(user => user.password, password));
                }*/

        public async Task Update(int userId, string name, string login, string password)
        {
            var User = await GetById(userId);
            
            if(User == null) throw new Exception();
            
            User.userId = userId;
            User.name = name;
            User.login = login;
            User.password = password;

            await _dbContext.SaveChangesAsync();
        }

        public async Task Delete(int userId)
        {
            var User = await GetById(userId);

            if (User == null) throw new Exception();

            _dbContext.Users.Remove(User);

            await _dbContext.SaveChangesAsync();
        }

    }
}
