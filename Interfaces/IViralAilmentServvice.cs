using Assignment1.Models;
namespace Assignment1.Interfaces;

public interface IViralAilmentService
{
    IEnumerable<ViralAilment> GetInfections();
    void ApplyFanumTax(string term);
    void DeleteCringe(string term); 
}