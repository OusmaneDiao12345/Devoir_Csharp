public class Absence
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public int EtudiantId { get; set; }
    public Etudiant Etudiant { get; set; }
    public int CoursId { get; set; }
    public Cours Cours { get; set; }
}
