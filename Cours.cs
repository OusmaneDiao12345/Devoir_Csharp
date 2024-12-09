public class Cours
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public TimeSpan HeureDebut { get; set; }
    public TimeSpan HeureFin { get; set; }
    public int NombreHeures { get; set; }
    public string Semestre { get; set; }
    public string Module { get; set; }
    public int ProfesseurId { get; set; }
    public Professeur Professeur { get; set; }
    public ICollection<Classe> Classes { get; set; }
}
