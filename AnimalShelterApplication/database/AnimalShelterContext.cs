using System.Data.Entity;

namespace AnimalShelterApplication.database
{
    public class AnimalShelterContext : DbContext
    {
        public DbSet<Clients> ClientsSet { get; set; }
    }

    public class Clients
    {
        public int primaryKey
        {
            get;
            set;
        }

        public string name
        {
            get;
            set;
        }

        public string surname
        {
            get;
            set;
        }

        public string adress
        {
            get;
            set;
        }
    }
}