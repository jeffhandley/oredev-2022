namespace contracts
{
    internal class Model
    {
        public required string FirstName { get; set; }
        public required string LastName { get; set; }

        private int ID = 42;

        [PrivateInfo]
        public string? TaxID { get; set; }
    }

    internal class PrivateInfoAttribute : Attribute
    {
    }
}
