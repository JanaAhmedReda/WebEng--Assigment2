using Assignment1.Models;
namespace Assignment1.Interfaces;

public interface IBrainRotterService
{
    IEnumerable<BrainRotter> GetLobby();
    void UpdateAura(int id, int amount);
    void Banish(int id);
}