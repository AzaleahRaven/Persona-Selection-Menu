using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PersonaSel : MonoBehaviour
{
    public List<Persona> personaCollection = new List<Persona>();

    public GameObject buttonPrefab;
    public Transform buttonContainer;
    public TextMeshProUGUI descriptionText;
    public Image personaImage;

    public Sprite orpheusSprite;
    public Sprite thanatosSprite;
    public Sprite messiahSprite;
    public Sprite kingFrostSprite;

    void Start()
    {
        Persona persona1 = new Persona("Orpheus", "''Thou art I... And I am thou... From the sea of thy soul I cometh... I am Orpheus, master of strings...''", Persona.ArcanaType.Fool, orpheusSprite, 57);
        Persona persona2 = new Persona("Thanatos", "''I am Thanatos, I was born of thee, and I shall walk by thy side.''", Persona.ArcanaType.Death, thanatosSprite, 88);
        Persona persona3 = new Persona("Messiah", "''I am Messiah. The heart of salvation that had been nurtured within you. Let it now be freed.''", Persona.ArcanaType.Judgement, messiahSprite, 99);
        Persona persona4 = new Persona("King Frost", "''I'm King Frost! Nice to meet ya! Hee ho!''", Persona.ArcanaType.Emperor, kingFrostSprite, 41);

        personaCollection.Add(persona1);
        personaCollection.Add(persona2);
        personaCollection.Add(persona3);
        personaCollection.Add(persona4);

        foreach (Persona p in personaCollection)
        {
            AddPersonaButton(p);
        }
    }

    public void AddPersonaButton(Persona persona)
    {
        GameObject newButton = Instantiate(buttonPrefab, buttonContainer);
        PersonaButton personaButton = newButton.GetComponent<PersonaButton>();

            personaButton.SetData(persona, this);
    }

    public void UpdateSprite(Sprite sprite)
    {
        if (sprite != null)
        {
            personaImage.sprite = sprite;
            personaImage.enabled = true;
            personaImage.preserveAspect = true;
        }
        else
        {
            personaImage.enabled = false;
        }
    }

    public void UpdateDescription(string description)
    {
        descriptionText.text = description;
    }
}
