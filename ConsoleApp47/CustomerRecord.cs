namespace ConsoleApp47
{
    internal record CustomerRecord
    {
        public int Id { get; init; }
        public string FullName { get; init; } = null!;
        public string Email { get; init; } = null!;
        public CustomerRecord(int id, string fullName, string email)
        {
            Id = id;
            FullName = fullName;
            Email = email;
        }
    }
}
