using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fuel : MonoBehaviour
{
    //private AudioSource finishSound;

    //private bool levelCompleted = false;

    private void Start()
    {
        //finishSound = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player" )
        {
            //finishSound.Play();
            Destroy(gameObject);
            //levelCompleted = true;
            //Invoke("CompleteLevel", 2f);
        }
    }

    //private void CompleteLevel()
   // {
    //    SceneManager.LoadScene("EndScreen");
   // }
}
