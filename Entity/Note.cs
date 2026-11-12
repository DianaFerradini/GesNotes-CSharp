namespace GesNotes.Entity;

public class Note(string matiere, double valeur)
{
    public string Matiere { get; set; } = matiere;
    public double Valeur
    {
        get;
        set;
    } = valeur >= 0 && valeur <= 20 ? valeur : throw new ArgumentOutOfRangeException(nameof(valeur), "La note doit être comprise entre 0 et 20.");
}