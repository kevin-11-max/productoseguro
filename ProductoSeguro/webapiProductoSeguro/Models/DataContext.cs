﻿
namespace webapiProductoSeguro.Models
{
    using System.Data.Entity;
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<webapiProductoSeguro.Models.Product> Products { get; set; }
    }
}