using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinPicker : MonoBehaviour
{
    public GameHandler GH;
    public AudioClip coinSound;
    private void Start()
    {
        
        GH = GameObject.Find("Canvas").GetComponent<GameHandler>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            GH.coins++;
            
            AudioSource.PlayClipAtPoint(coinSound, transform.position, 0.5f);
            Destroy(gameObject);
        }
    }
}
