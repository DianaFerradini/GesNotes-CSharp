namespace GesNotes.Repository;

using GesNotes.Entity;

public interface IEtudiantRepository
{
    void Save(Etudiant etudiant);
    List<Etudiant> FindAll();
    Etudiant? FindByMatricule(string matricule);
}