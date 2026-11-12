namespace GesNotes.Service;

using GesNotes.Dto;

public interface IEtudiantService
{
    bool AjouterEtudiant(EtudiantSaisieDto etudiant);
    List<EtudiantListSimpleDto> ListerEtudiants();
}