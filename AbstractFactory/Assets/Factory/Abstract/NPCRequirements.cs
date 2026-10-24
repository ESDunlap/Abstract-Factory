using UnityEngine;

public enum Richness
{
    Low,
    Middle,
    High
}

public class NPCRequirements
{
    public bool Friendly { get; set; }
    public Richness RichLevel { get; set; }
}
