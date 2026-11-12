namespace GesNotes.Dto;

public record EtudiantListSimpleDto
{
    private readonly string _matricule;
    private readonly string _nomComplet;
    private readonly string _dateNaiss;
    private readonly int _age;
    public required string Matricule
    {
        get => _matricule;
        init => _matricule = value;
    } 
    public required string NomComplet
    {
        get => _nomComplet;
        init => _nomComplet = value;
    } 
    public required string DateNaiss
    {
        get => _dateNaiss;
        init => _dateNaiss = value;
    } 
    public required int Age
    {
        get => _age;
        init => _age = value;
    } 
}