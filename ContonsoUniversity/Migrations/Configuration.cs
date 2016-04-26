namespace ContonsoUniversity.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using ContonsoUniversity.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<ContonsoUniversity.DAL.SchoolContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ContonsoUniversity.DAL.SchoolContext context)
        {
          
        }
    }
}
