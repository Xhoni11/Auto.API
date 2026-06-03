namespace Auto.API;

public class Car
{
    public int Id { get; set; }
    public string Marka { get; set; } = string.Empty;
    public string Modeli { get; set; } = string.Empty;
    public int Viti { get; set; }
    public decimal Cmimi { get; set; }
    public string Ngjyra { get; set; } = string.Empty;
    public int Kilometra { get; set; }
    public string Karburanti { get; set; } = string.Empty;
    public string Transmisioni { get; set; } = string.Empty;
    public bool NeShitje { get; set; }
    public string ImazhUrl { get; set; } = string.Empty;
}
