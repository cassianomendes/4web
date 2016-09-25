using FourWeb.Abstraction.Domain.Entities;
using System.Collections.Generic;

namespace FourWeb.Migrations.DatabaseModel
{
    public class Category : EntityBase
    {
        public string Title { get; private set; } 
    }
}
