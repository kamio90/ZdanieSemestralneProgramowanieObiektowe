using System.Data.Entity;

namespace AnimalShelterApplication.database
{
    public class AnimalShelterContext : DbContext
    {
        public AnimalShelterContext() : base("mssql")
        {
            
        }
    }
}