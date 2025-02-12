using ConsoleApp1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Repositories
{
    internal class EntityApp
    {
        private EntityRepo repo;
        public EntityApp(List<EntityClass> data)
        {
            repo = new EntityRepo();
            foreach(var item in data)
            {
                repo.AddNewEntity(item);
            }
        }

        public List<EntityClass> SortById()
        {
            var data = repo.GetEntities();
            data.OrderByDescending(x => x.Id);
            return data;
        }
        public List <EntityClass> SortByName()
        {
            var data = repo.GetEntities();
            data.Sort((c1, c2) => c1.StringData.CompareTo(c2.StringData));
            return data;
        }
    }
}
