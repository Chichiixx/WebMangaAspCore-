using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebMangaAspCore.Models.Persistance;
using WebMangaAspCore.Models.Dao;
using WebMangaAspCore.Models.MesExceptions;
using System.Data;

namespace WebMangaAspCore.Models.Dao
{
    public class ServiceManga
    {
        public static DataTable GetTousLesManga()
        {
            DataTable mesMangas;
            Serreurs er = new Serreurs("Erreur sur la lecture des Mangas.", "Manga.getMangas()");
            try
            {
                String mysql = "Select id_manga, lib_genre, nom_dessinateur, nom_scenariste, titre, prix, couverture ";
                mysql += "from manga join genre on manga.id_genre = genre.id_genre ";
                mysql += "join dessinateur on manga.id_dessinateur = dessinateur.id_dessinateur ";
                mysql += "join scenariste on manga.id_scenariste = scenariste.id_scenariste ";

                mesMangas = DBInterface.Lecture(mysql, er);

                return mesMangas;

            }
            catch (Exception e)
            {
                throw new MonException(er.MessageUtilisateur(), er.MessageApplication(), e.Message);
            }
        }
    }
}