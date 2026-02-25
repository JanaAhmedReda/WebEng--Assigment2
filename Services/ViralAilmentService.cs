using Assignment1.Models;
using Assignment1.Interfaces;

namespace Assignment1.Services;

public class ViralAilmentService : IViralAilmentService
{
    private List<ViralAilment> _ailments = new List<ViralAilment>
    {
        new ViralAilment { Term = "Skibidi", CringeLevel = 95, OriginApp = "YouTube" },
        new ViralAilment { Term = "Fanum Tax", CringeLevel = 60, OriginApp = "Twitch" },
        new ViralAilment { Term = "Mewing", CringeLevel = 30, OriginApp = "TikTok" }
    };

    public IEnumerable<ViralAilment> GetInfections() => _ailments;

    public void ApplyFanumTax(string term)
    {
        var ailment = _ailments.FirstOrDefault(a => a.Term.ToLower() == term.ToLower());
        if (ailment != null)
        {
            
            ailment.CringeLevel = (int)(ailment.CringeLevel * 0.8);
        }
    }

    public void DeleteCringe(string term)
    {
        var ailment = _ailments.FirstOrDefault(a => a.Term.ToLower() == term.ToLower());
        if (ailment != null) _ailments.Remove(ailment);
    }
}