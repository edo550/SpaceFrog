using UnityEngine;
using TMPro;

public class DialogueUI : MonoBehaviour
{

    [SerializeField] private TMP_Text textLabel;

    // Start is called before the first frame update
    private void Start()
    {
        GetComponent<TypewriterEffect>().Run("La rana spaziale e' in missione per cercare la vita in diversi pianeti, questo e' il primo, il pianeta Miller.\nTutto sembra bello dalla spazio, ma una volta al suo interno il pianeta non presente forme di vita, essendo un pianeta solo di acqua.\nRiuscira' la nostra rana ad arrivare alla sua navicella spaziale?", textLabel);
    }


}
