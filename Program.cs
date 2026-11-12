namespace GesNotes;

using System.ComponentModel.Design;
using GesNotes.Entity;
using GesNotes.View;

class Program {
    private static List<Etudiant> etudiants = new();
    public static void Main(string[] args) {
        int compteur = 1;
        int choix;
        do
        {
            choix = EtudiantView.Menu();
            switch (choix)
            {  
                case 0: 
                    Console.WriteLine("Au revoir");
                    break;

                case 1:
                    var etudiant = EtudiantView.SaisieEtudiant();
                    etudiants.Add(etudiant);
                    break;

                case 2:
                    EtudiantView.AfficherEtudiants(etudiants);
                    break;

                case 3:
                    string matricule = EtudiantView.LireChaine("Saisir le matricule à rechercher : ");
                    Etudiant? etudiantNullable= GetEtudiantByMatricule(matricule);
                    if (etudiantNullable is null)
                    {
                        Console.WriteLine("Ce matricule ne correspond à aucun étudiant");
                    } else
                    {
                        bool result = true;
                        Note note;
                        do
                        {
                            string matiere = EtudiantView.LireChaine("Saisir la matière :");
                            double valeur = EtudiantView.LireDouble("Saisir une note entre 0 et 20 : ");
                            try
                            {
                                note = new Note(matiere, valeur);
                                etudiantNullable?.AddNote(note);
                            }
                            catch (ArgumentOutOfRangeException e)
                            {
                                Console.WriteLine(e.Message);
                                result = false;
                            }
                        } while (!result);
                    }
                    break;

                case 4:
                    matricule = EtudiantView.LireChaine("Saisir le matricule : ");
                    etudiantNullable= GetEtudiantByMatricule(matricule);
                    if (etudiantNullable is null)
                    {
                        Console.WriteLine("Ce matricule ne correspond à aucun étudiant");
                    } else
                    {
                        var notes = etudiantNullable?.Notes;
                        notes?.ForEach(n => Console.WriteLine(n));
                    }
                    break;
                
                default: 
                    Console.WriteLine("Saisir un entier entre 0 et 4");
                    break;
            }
        } while (choix != 0);
        
    }

    

    
}
