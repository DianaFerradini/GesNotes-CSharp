namespace GesNotes.Entity;

public class Etudiant(string matricule, string nom, DateOnly dateNaiss)
{
    public string Matricule {get; set;} = matricule;
    public string NomComplet {get; set;} = nom;
    public DateOnly DateNaiss {get; set;} = dateNaiss;
    public int Age
    {
        get
        {
            var now = DateOnly.FromDateTime(DateTime.Today);
            var age = now.Year - DateNaiss.Year;
            return age;
        }
    }
    public List<Note> Notes {get;} = [];

    public void AddNote(Note note)
    {
        Notes.Add(note);
    }
}