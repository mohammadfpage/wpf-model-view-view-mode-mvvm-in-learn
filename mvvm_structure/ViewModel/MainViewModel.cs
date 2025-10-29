using mvvm_structure.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvvm_structure.ViewModel
{
    public class MainViewModel
    {
        private List<MainModel> _mainModelList = new List<MainModel>();

        public MainViewModel()
        {
            _mainModelList.Clear();
            _mainModelList.Add(
                new MainModel(1, "mohammad", "fallahi", 22, DateTime.Now, DateTime.Now)
                );
        }

        public List<MainModel> MainModelList
        {
            get { return _mainModelList; }

            set { _mainModelList = value; }
        }
    }
}
