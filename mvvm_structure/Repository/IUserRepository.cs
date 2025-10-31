using mvvm_structure.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvvm_structure.Repository
{
    public interface IUserRepository
    {
        public Task Create(MainModel model);

        public Task Update(MainModel model);

        public Task Delete(int id);

        public Task<List<MainModel>> GetAll();

        public Task<MainModel> GetByIdAsync(int id);
    }
}
