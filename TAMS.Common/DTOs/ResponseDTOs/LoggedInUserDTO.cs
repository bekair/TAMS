namespace TAMS.Common.DTOs.ResponseDTOs
{
    public record LoggedInUserDTO
    {
        public int Id { get; init; }
        public string UserName { get; init; }
    }
}
