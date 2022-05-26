using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    //public AudioClip coinSound;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            //AudioSource.PlayClipAtPoint(coinSound, transform.position, 4f);
            FindObjectOfType<audioManager>().Coin();
            CoinCounterScript.coinAmount += 1;
            Destroy(gameObject);
        }
    }
}
