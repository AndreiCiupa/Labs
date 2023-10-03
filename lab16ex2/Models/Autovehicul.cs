using Azure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab16ex2.Models
{
    internal class Autovehicul
    {
        public int Id { get; set; }
        public string Nume { get; set; }
        public string SerieDeSasiu { get; set; }
        public int AnFabricatie { get; set; }
        public Producator Producator { get; set; }
        public override string ToString() =>
            $"ID: {Id} Nume: {Nume}, Serie de sasiu: {SerieDeSasiu}, An fabricatie: {AnFabricatie}";
    }
}
