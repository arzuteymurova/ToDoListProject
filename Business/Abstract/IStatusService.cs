using System.Collections.Generic;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IStatusService
    {
        List<Status> GetAll();
        void Add(Status status);
        void Update(Status status);
        void Delete(Status status);
      
    }
}