using Microsoft.AspNetCore.Mvc;
using WebMangaAspCore.Models.Dao;
using WebMangaAspCore.Models.MesExceptions;

namespace WebMangaAspCore.Controllers
{
	public class MangaController : Controller
	{
		public IActionResult Index()
		{
			System.Data.DataTable mesMangas = null;
			try
			{
				mesMangas = ServiceManga.GetTousLesManga();
			}
			catch (MonException e)
			{
				ModelState.AddModelError("Erreur", "Erreur lors de la récupération des mangas : " + e.Message);
			}

			return View(mesMangas);
		}
	}
} 
