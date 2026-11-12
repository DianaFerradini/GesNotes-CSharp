namespace GesNotes.Dto;

public record EtudiantSaisieDto
{
    private readonly string _nomComplet;
    private readonly string _dateNaiss;
    public required string NomComplet
    {
        get
        {
            return _nomComplet;
        }
        init
        {
            if (value.Trim() == "")
            {
                throw new ArgumentException("Le nom ne peut pas être vide.");
            }
            return value.Trim();
        }
    }
    public required string DateNaiss
    {
        get
        {
            return _dateNaiss;
        }
        init
        {
            if (value.Trim() == "")
            {
                throw new ArgumentException("La date de naissance ne peut pas être vide.");
            }
            if (!DateOnly.TryParseExact(value, "dd/MM/yyyy", out _))
            {
                throw new ArgumentException("La date doit être au format dd/MM/yyyy.");
            }
            return value.Trim();
        }
    }
}