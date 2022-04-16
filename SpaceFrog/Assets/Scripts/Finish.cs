

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    //private AudioSource finishSound;
    public Animator animator;

    private bool levelCompleted = false;

    private void Start()
    {
        //finishSound = GetComponent<AudioSource>();
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player" && !levelCompleted)
        {
            //finishSound.Play();
            Destroy(collision.gameObject);
            animator.SetBool("Finish", true);
            levelCompleted = true;
            Invoke("CompleteLevel", 4f);
        }
    }

    private void CompleteLevel()
    {
        SceneManager.LoadScene("EndScreen");
    }
}