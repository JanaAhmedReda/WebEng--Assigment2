namespace Assignment1.Models;

public class ViralAilment 
{
    public string? Term { get; set; }
    public int CringeLevel { get; set; }
    public string? OriginApp { get; set; }

    public string GetDiagnosis()
    {
        return CringeLevel > 80 ? "Terminal Brain Rot" : "Slightly Cooked";
    }
}