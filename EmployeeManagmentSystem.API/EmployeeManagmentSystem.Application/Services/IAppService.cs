using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagmentSystem.Application.Services
{
    public interface IAppService<TEntity> where TEntity : class
    {
        bool Commit();
        public List<TEntity> GetAll();
        public TEntity GetById(int id);
        public bool Delete(int id);
        public void Insert(TEntity entity);
        public void Update(TEntity entity, int id);
    }
}
