using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProEventosMEU.API.Models;


namespace ProEventosMEU.API.Data
{
    public class DataConstext : DbContext
    {
        public DataConstext(DbContextOptions<DataConstext> options) : base(options) { }
        
        public DbSet<Evento> Eventos { get; set; }
    }
}