public class Classe
{
    public int Id { get; set; }
    public string Libelle { get; set; }
    public string Filiere { get; set; }
    public ICollection<Etudiant> Etudiants { get; set; }
    public ICollection<Cours> Cours { get; set; }
}
