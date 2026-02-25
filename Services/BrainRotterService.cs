using Assignment1.Models;
using Assignment1.Interfaces;

namespace Assignment1.Services;

public class BrainRotterService : IBrainRotterService
{
    
    private List<BrainRotter> _rotters = new List<BrainRotter>
    {
        new BrainRotter { Id = 1, Name = "The Rizzler", AuraPoints = 5000, HomeState = "Ohio", IsMewing = true },
        new BrainRotter { Id = 2, Name = "Baby Gronk", AuraPoints = -100, HomeState = "Ohio", IsMewing = false },
        new BrainRotter { Id = 3, Name = "Skibidi Scientist", AuraPoints = 420, HomeState = "Ohio", IsMewing = false }
    };



    public IEnumerable<BrainRotter> GetLobby() => _rotters;

    public void UpdateAura(int id, int amount)
    {
        var rotter = _rotters.FirstOrDefault(r => r.Id == id);
        if (rotter != null) rotter.AuraPoints += amount;
    }

    public void Banish(int id)
    {
        var rotter = _rotters.FirstOrDefault(r => r.Id == id);
        if (rotter != null) _rotters.Remove(rotter);
    }
}