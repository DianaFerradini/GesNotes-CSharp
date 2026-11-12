namespace GesNotes.View;

using GesNotes.Entity;

public static class EtudiantView
{
    public static int Menu() {
        bool result = false;
        int choix = 0;
        do
        {
            Console.WriteLine("1. Ajouter un etudiant dans une liste");
            Console.WriteLine("2. Afficher la liste des étudiants");
            Console.WriteLine("3. Ajouter une note a un etudiant");
            Console.WriteLine("4. Lister les notes d'un etudiant");
            Console.WriteLine("0. Quitter");
            Console.WriteLine("Saisir votre choix : ");
            result = int.TryParse(Console.ReadLine(), out choix);
        } while (!result);
        return choix;
    }

    public static Etudiant SaisieEtudiant()
    {
        return new Etudiant(LireChaine("Nom complet : "), ChaineToDateOnly());
    }

    public static string LireChaine(string msg)
    {
        string? chaine;
        do
        {
            Console.WriteLine(msg);
            chaine = Console.ReadLine();
        } while (chaine == null);
        return chaine;
    }

    public static double LireDouble(string msg)
    {
        bool result = false;
        double choix = 0;
        do
        {
            Console.WriteLine(msg);
            result = double.TryParse(Console.ReadLine(), out choix);
        } while (!result);
        return choix;
    }

    public static DateOnly ChaineToDateOnly()
    {
        bool result = false;
        DateOnly dateNaiss;
        do
        {
            string dateString = LireChaine("Saisir la date de naissance (dd/MM/yyyy) :");
            result = DateOnly.TryParseExact(dateString, "dd/MM/yyyy", out dateNaiss);
        } while (!result);
        return dateNaiss;
    }

    public static void AfficherEtudiants(List<Etudiant> etudiants)
    {
        etudiants.ForEach(e => Console.WriteLine($"Matricule : {e.Matricule} ; Nom et prénom : {e.NomComplet} ; Date de naissance : {e.DateNaiss.ToString()}"));
    }
} 