namespace GesNotes.Service;

internal interface IDateService
{
    DateOnly ChaineToDateOnly(string chaine);
}