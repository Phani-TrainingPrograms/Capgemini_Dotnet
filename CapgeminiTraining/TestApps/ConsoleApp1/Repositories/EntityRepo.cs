using ConsoleApp1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Repositories
{
    internal class EntityRepo
    {
        private List<EntityClass> entities = new List<EntityClass>();

        public void AddNewEntity(EntityClass entity)
        {
            if(entity  == null) throw new ArgumentNullException("Entity details are not set");
            if(entities.Contains(entity)) 
                throw new Exception("Entity already exists");
            entities.Add(entity);
        }

        public void DeleteEntity(int id)
        {
            var rec = entities.Find(x => x.Id == id);
            if(rec != null)
            {
                entities.Remove(rec);
            }
            else
            {
                throw new KeyNotFoundException("Id not found to delete");
            }
        }

        public List<EntityClass> GetEntities() => entities;

        public void UpdateEntity(EntityClass entity)
        {
            //find the entity
            var found = entities.Find(e => e.Id == entity.Id);
            if(found != null)
            {
                //update the values
                found.StringData = entity.StringData;
                found.DateOfBirth = entity.DateOfBirth;
                found.LongNo = entity.LongNo;
            }
            else throw new KeyNotFoundException("id not found to update");
        }
    }
}
