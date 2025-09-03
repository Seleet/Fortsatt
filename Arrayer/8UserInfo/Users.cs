namespace Users
{
    public class User
    {
        public string Namn { get; set; }
        public string Adress { get; set; }
        public int Postnummer { get; set; }
        public string Postort { get; set; }

        public User(string namn, string adress, int postnummer, string postort)
        {
            Namn = namn;
            Adress = adress;
            Postnummer = postnummer;
            Postort = postort;

        }

    }

}


