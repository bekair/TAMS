using TAMS.Entity.Base;

namespace TAMS.Entity.Concrete
{
    public class Trainee : EntityBase
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}
