namespace GesNotes.Service;

internal class DateService
{
    DateOnly ChaineToDateOnly(string chaine, string format = "dd/MM/yyyy")
    {
        DateOnly date;
        result = DateOnly.TryParseExact(chaine, format, out date);
        return date;
    }
}