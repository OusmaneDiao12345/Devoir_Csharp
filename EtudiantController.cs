

using GestionCoursAbsences.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

public class EtudiantController : Controller
{
    private readonly ApplicationDbContext _context;

    public EtudiantController(ApplicationDbContext context)
    {
        _context = context;
    }

    // Lister les cours d’un étudiant
    public IActionResult MesCours(int etudiantId)
    {
        var cours = _context.Cours
            .Where(c => c.Classes
                .SelectMany(cl => cl.Etudiants)
                .Any(e => e.Id == etudiantId))
            .ToList();
        return View(cours);
    }

    // Lister les absences d’un étudiant
    public IActionResult MesAbsences(int etudiantId)
    {
        var absences = _context.Absences
            .Where(a => a.EtudiantId == etudiantId)
            .Include(a => a.Cours)
            .ToList();
        return View(absences);
    }
}
