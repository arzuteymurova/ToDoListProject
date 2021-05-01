using Core.Entities;

namespace Entities.Concrete
{
    public class Status : IEntity
    {
        public int StatusId { get; set; }
        public string StatusName { get; set; }
      
    }
}