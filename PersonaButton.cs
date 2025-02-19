using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PersonaButton : MonoBehaviour
{
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI arcanaText;
    public TextMeshProUGUI levelText;
    public Image personaImage;

    private Persona persona;
    private PersonaSel personaSel;
    private PersonaSel personaManager;
    private Button button;
    

    public void SetData(Persona persona, PersonaSel manager)
    {
        this.persona = persona;
        this.personaManager = manager;
        nameText.text = persona.name;
        arcanaText.text = persona.arcana.ToString();
        levelText.text = persona.level.ToString();

        button = GetComponent<Button>();
        button.onClick.AddListener(OnButtonClick);
    }

    public void OnButtonClick()
    {
        Debug.Log("Button clicked: " + persona.name);
        personaManager.UpdateDescription(persona.description);
        personaManager.UpdateSprite(persona.sprite);
    }

}
