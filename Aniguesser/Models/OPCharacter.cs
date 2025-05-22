public class OPCharacter
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Gender { get; set; }
    public string Affiliation { get; set; }
    public string DevilFruit { get; set; }
    public long? Bounty { get; set; }
    public string Origin { get; set; }
    public List<string> HakiTypes { get; set; }

    public OPCharacter()
    {
        HakiTypes = new List<string>();
    }
}