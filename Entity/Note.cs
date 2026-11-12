namespace GesNotes.Entity;

public class Note
{
    public string Matiere { get; set; }
    public double Valeur
    {
        get;
        set
        {
            if (valeur < 0 || valeur > 20)
            {
                throw new ArgumentOutOfRangeException(nameof(valeur), "La note doit être comprise entre 0 et 20.");
            }
            return valeur;
        }
    }
}