namespace GesNotes.Service;

using GesNotes.Dto;
using GesNotes.Repository;

public class EtudiantService : IEtudiantService
{
    private IEtudiantRepository _repository;
    public EtudiantService(IEtudiantRepository repository)
    {
        _repository = repository;
    }
    public bool AjouterEtudiant(EtudiantSaisieDto etudiantDto, IMatriculeService matriculeService, IDateService dateService)
    {
        var matricule = matriculeService.GenererMatricule(_repository.Compteur);
        var dateNaiss = dateService.ChaineToDateOnly(etudiantDto.DateNaiss);
        // Etudiant etudiant = new Etudiant(matricule, etudiantDto.NomComplet, dateNaiss);
        Etudiant etudiant = new Etudiant
        {
            NomComplet = etudiantDto.NomComplet,
            Matricule = matricule,
            DateNaiss = dateNaiss
        };
        _repository.Save(etudiant);
        return true;
    }
    public List<EtudiantListSimpleDto> ListerEtudiants();
}