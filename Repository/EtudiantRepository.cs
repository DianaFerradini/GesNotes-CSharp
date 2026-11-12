namespace GesNotes.Repository;

using GesNotes.Entity;

public class EtudiantRepository : IEtudiantRepository
{
    //singleton
    private EtudiantRepository() {}

    private static EtudiantRepository? _instance = null;

    public static EtudiantRepository? GetInstance()
    {
        if (_instance is null)
        {
            _instance = new EtudiantRepository();
        }
        return _instance;
    }

    //repository
    private List<Etudiant> _etudiants = [];
    public int Compteur {get; private set;} = 1;

    public void Save(Etudiant etudiant)
    {
        _etudiants.Add(etudiant);
        Compteur++;
    }
    public List<Etudiant> FindAll() => _etudiants;
    public Etudiant? FindByMatricule(string matricule) => _etudiants.FirstOrDefault(e => e.Matricule == matricule);
    
}