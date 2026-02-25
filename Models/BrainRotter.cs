namespace Assignment1.Models;

public class BrainRotter 
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int AuraPoints { get; set; }
    public string? HomeState { get; set; }
    public bool IsMewing { get; set; }

    public string Talk()
    {
        return IsMewing ? "..." : "Skibidi Toilet!";
       
    }
}