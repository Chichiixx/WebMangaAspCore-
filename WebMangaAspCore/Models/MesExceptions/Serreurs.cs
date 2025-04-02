using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace WebMangaAspCore.Models.MesExceptions
{
    public class Serreurs
    {
        private string _MessageUtilisateur, _MessageApplication;
        public Serreurs(string mu, string ma)
        {
            _MessageUtilisateur = mu;
            _MessageApplication = ma;
        }
        public string MessageUtilisateur()
        {
            return _MessageUtilisateur;
        }
        public string MessageApplication()
        {
            return _MessageApplication;
        }
    }
}