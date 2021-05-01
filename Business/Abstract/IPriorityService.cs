using System.Collections.Generic;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IPriorityService
    {
        List<Priority> GetAll();
        void Add(Priority priority);
        void Update(Priority priority);
        void Delete(Priority priority);
       // int GetByName(string name);
    }
}