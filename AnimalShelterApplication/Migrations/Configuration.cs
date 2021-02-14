
using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

namespace AnimalShelterApplication.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<AnimalShelterApplication.database.AnimalShelterContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }
    } 
}