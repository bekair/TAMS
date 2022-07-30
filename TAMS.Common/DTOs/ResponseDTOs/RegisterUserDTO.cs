using TAMS.Common.Enums;

namespace TAMS.Common.DTOs.ResponseDTOs
{
    public class RegisterUserDTO
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Gender Gender { get; set; }

        public int Age { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }
    }
}
