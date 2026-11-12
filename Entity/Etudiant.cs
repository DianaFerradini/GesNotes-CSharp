namespace GesNotes.Entity;

public class Etudiant
{
    public string Matricule {get; set;}
    public string NomComplet {get; set;}
    public DateOnly DateNaiss {get; set;}
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