namespace TAMS.Common.DTOs.ResponseDTOs
{
    public record SignedInUserDTO
    {
        public int Id { get; init; }
        public string UserName { get; init; }
    }
}
