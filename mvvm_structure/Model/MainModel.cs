using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvvm_structure.Model
{
    public class MainModel
    {
        private int id , age;

        private string name , family;

        private DateTime create , update;

        public MainModel(int user_id,string user_name , string user_family , int user_age , DateTime user_create , DateTime user_update)
        {
            id = user_id;
            name = user_name;
            family = user_family;
            age = user_age;
            create = user_create;
            update = user_update;
        }

        public int Id
        {
            get { return id; }
            set { value = id; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Family
        {
            get { return family; }
            set { family = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public DateTime Create
        {
            get { return create; }
            set { create = value; }
        }

        public DateTime Update
        {
            get { return update; }
            set { update = value; }
        }
    }
}
