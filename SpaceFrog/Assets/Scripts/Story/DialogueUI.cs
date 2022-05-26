using UnityEngine;
using TMPro;

public class DialogueUI : MonoBehaviour
{

    [SerializeField] private TMP_Text textLabel;

    // Start is called before the first frame update
    private void Start()
    {
        FindObjectOfType<audioManager>().TypeWriter();
        GetComponent<TypewriterEffect>().Run("L'astronauta e' missione con l'obiettivo di esplorare nuovi pianeti alla ricerca di possibile vita.\n" +
			"Adesso ci troviamo nel pianeta di classe M(perfettamente adatto alla vita umana) denominato Altair. " +
			"L'esploratore e' rimasto bloccato in questo pianeta, a causa di una perdita di carburante, " +
			"devi aiutarlo a ritornare in orbita. \n\n\n" +
			"Ricordarti di raccogliere il carburante.", textLabel);
    }


}
