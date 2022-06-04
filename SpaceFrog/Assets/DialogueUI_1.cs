using UnityEngine;
using TMPro;

public class DialogueUI_1 : MonoBehaviour
{

    [SerializeField] private TMP_Text textLabel;

    // Start is called before the first frame update
    private void Start()
    {
        FindObjectOfType<audioManager>().TypeWriter();
        GetComponent<TypewriterEffect>().Run("Per fortuna siamo riusciti a scappare da questo pianeta. Si è " +
			"rivelato proprio un buco nell'acqua.\n" +
			"Adesso ci aspetta un breve viaggio prima di raggiungere il secondo ed ultimo pianeta da visitare," +
			"nella speranza di trovare condizioni adatte per la vita umana.\n" +
			"I dati non promettono bene, sembra sia un pianeta morto, con temperature oltre i 60°C con presenza di forme di vita." +
			"\n\n" +
			"speriamo bene", textLabel);
    }


}
