namespace UPC.HomeFlavors.API.Profiles.Domain.Model.Aggregates
{
    public class Profile
    {
        public int Id { get; }
        public string Name { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }
        public string Cellphone { get; private set; }

        public Profile(string name, string lastname, string email, string cellphone)
        {
            Name = name;
            LastName = lastname;
            Email = email;
            Cellphone = cellphone;
        }
    }
}