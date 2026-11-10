class Program {
    public static void Main(string[] args) {
        List<(string matricule, string nom, string prenom, List<double> notes)> etudiants = new List<(string matricule, string nom, string prenom, List<double> notes)>();
        etudiants.Add(("ism001", "Ba", "Amadou", new List<double>{10, 12.5, 14}));

        int choix;
        do
        {
            choix = Menu();
            switch (choix)
            {  
                case 0: 
                    Console.WriteLine("Au revoir");
                    break;
                
                default: 
                    Console.WriteLine("Saisir un entier entre 0 et 4");
                    break;
            }
        } while (choix != 0);
        
    }

    public static int Menu() {
        bool result = false;
        int choix = 0;
        do
        {
            Console.WriteLine("1. Ajouter un etudiant dans une liste");
            Console.WriteLine("2. Afficher la liste des étudiants");
            Console.WriteLine("3.Ajouter une note a un etudiant");
            Console.WriteLine("4. Lister les notes d'un etudiant");
            Console.WriteLine("0. Quitter");
            Console.WriteLine("Saisir votre choix : ");
            result = int.TryParse(Console.ReadLine(), out choix);
        } while (!result);
        return choix;
    }
}
