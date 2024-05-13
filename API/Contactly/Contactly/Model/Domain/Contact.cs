namespace Contactly.Model.Domain
{
    public class Contact
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }

        public required string Email { get; set; }

        public required string PhoneNumber { get; set; }

        public bool IsFavorite  { get; set; }
    }
}
