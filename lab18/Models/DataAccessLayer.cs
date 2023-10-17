using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab18.Models
{
    /*
        • Creeati modelul, Adaugati DB, populati DB

        • Scrieti urmatoarele metode
            • Adaugare autovehicul
                • Implica adaugarea carei entitati?
            • Adaugare producator
            • Adaugare cheie unui autovehicul
            • Inlocuire carte tehnica
            • Stergere autovehicul
            • Stergere producator
            • Stergere cheie

        • Determinati relatiile necesare

        • Determinati delete propagation-ul necesar pentru fiecare
        relatie in parte
    */
    internal static class DataAccessLayer
    {
        public static void AddAutvehicul()
        {
            using var ctx = new ParcAutoDBContext();

            ctx.SaveChanges();
        }
        public static void AddProducator()
        {
            using var ctx = new ParcAutoDBContext();

            ctx.SaveChanges();
        }
        public static void AddCheie()
        {
            using var ctx = new ParcAutoDBContext();

            ctx.SaveChanges();
        }
        public static void ChangeCarteTehnica()
        {
            using var ctx = new ParcAutoDBContext();

            ctx.SaveChanges();
        }
        public static void DeleteAtovehicul(int autovehiculId)
        {
            using var ctx = new ParcAutoDBContext();

            var autovehicul = ctx.Producatori.FirstOrDefault(p => p.Id == producatorId);

            if (autovehicul == null) { return; }

            ctx.Remove(autovehicul);
            ctx.SaveChanges();
        }
        public static void DeleteProducator(int producatorId)
        {
            using var ctx = new ParcAutoDBContext();

            var producator = ctx.Producatori.FirstOrDefault(p => p.Id == producatorId);

            if (producator == null) { return; }

            ctx.Remove(producator);
            ctx.SaveChanges();
        }
        public static void DeleteCheie(int cheieId) 
        {
            using var ctx = new ParcAutoDBContext();

            var cheie = ctx.Chei.FirstOrDefault(c => c.Id == cheieId);

            if (cheie == null) { return; }

            ctx.Remove(cheie);
            ctx.SaveChanges();
        }
    }
}
