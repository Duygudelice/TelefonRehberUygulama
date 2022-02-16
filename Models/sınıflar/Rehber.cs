using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace telefonrehberuygulaması.Models.sınıflar
{
    public class Rehber
    {
        [Key]
        public int ID { get; set; }
        public String AdSoyad { get; set; }
        public String numara { get; set; }
    }
}