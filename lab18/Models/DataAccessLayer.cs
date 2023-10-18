using Microsoft.SqlServer.Server;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
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
        //Implica adaugarea cartii tehnice
        public static void AddAutvehicul(string nume, int producatorId, int newCapac, int newAn, string newSerie)
        {
            using var ctx = new ParcAutoDBContext();

            var producator = ctx.Producatori.FirstOrDefault(p => p.Id == producatorId);
            if (producator == null) { return; }

            var newCarte = new CarteTehnica
            {
                CaapacitateCilindrica = newCapac,
                AnFabricatie = newAn,
                SerieDeSasiu = newSerie
            };

            var newAutovehicul = new Autovehicul
            {
                Nume = nume,
                Producator = producator,
                CarteTehnica = newCarte
            };

            producator.Autovehicule.Add(newAutovehicul);

            ctx.SaveChanges();
        }
        public static void AddProducator(string nume, string adresa)
        {
            using var ctx = new ParcAutoDBContext();

            ctx.Producatori.Add(new Producator
            {
                Nume = nume,
                Adresa = adresa
            });

            ctx.SaveChanges();
        }
        //Adauga o cheie nou la un autovehicul existent
        public static void AddCheie(int autovehiculId)
        {
            using var ctx = new ParcAutoDBContext();

            var autoveh = ctx.Autovehicule.FirstOrDefault(p => p.Id.Equals(autovehiculId));
            if (autoveh == null) { return ; }

            var newCheie = new Cheie();

            ctx.Chei.Add(newCheie);

            autoveh.Chei.Add(newCheie);

            ctx.SaveChanges();
        }
        public static void ChangeCarteTehnica(int carteVecheId, int newCapacitate, int newAnF, string newSerie)
        {
            using var ctx = new ParcAutoDBContext();

            var carteT = ctx.CartiTehnice.FirstOrDefault(c => c.Id == carteVecheId);
            
            if (carteT != null) { return; }

            carteT.CaapacitateCilindrica = newCapacitate;
            carteT.AnFabricatie = newAnF;
            carteT.SerieDeSasiu = newSerie;

            ctx.SaveChanges();
        }
        public static void DeleteAtovehicul(int autovehiculId)
        {
            using var ctx = new ParcAutoDBContext();

            var autovehicul = ctx.Autovehicule.FirstOrDefault(p => p.Id == autovehiculId);

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
