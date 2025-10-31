using mvvm_structure.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvvm_structure.Service
{
    public interface IUserService
    {
        public Task<MainModel> Update(MainModel model);
        public Task<MainModel> Create(MainModel model);
        public Task<MainModel> Delete(int id);
        public Task<List<MainModel>> Get();
    }
}
