namespace Person.Common.DTO
{
    public class PersonDTO
    {
        public long Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public long? AddressId { get; set; }
        public virtual AddressDTO Address { get; set; }

    }
}