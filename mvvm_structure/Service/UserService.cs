using mvvm_structure.Model;
using mvvm_structure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvvm_structure.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        

        public Task<MainModel> Create(MainModel model)
        {
            throw new NotImplementedException();
        }

        public Task<MainModel> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<MainModel>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<MainModel> Update(MainModel model)
        {
            throw new NotImplementedException();
        }
    }
}
