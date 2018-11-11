using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication4.Models
{
    public abstract class Klient
    {
        public int Id { get; set; }
        public String Email { get; set; }
        public String Haslo { get; set; }
        public Adres Adres { get; set; }
    }
}