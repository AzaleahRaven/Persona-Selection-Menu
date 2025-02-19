using UnityEngine;

[System.Serializable]
public class Persona
{
    public string name;
    public string description;
    public ArcanaType arcana;
    public Sprite sprite;
    public int level;

    public enum ArcanaType { Fool, Magician, Judgement, Star, Emperor, Death, Unknown }

    public Persona() // Default Persona
    {
        name = "Unknown";
        description = "Unknown";
        arcana = ArcanaType.Unknown;
        sprite = null;
        level = 0;
    }

    public Persona(string name, string description, ArcanaType arcana, Sprite sprite, int level)
    {
        this.name = name;
        this.description = description;
        this.arcana = arcana;
        this.sprite = sprite;
        this.level = level;
    }
}
