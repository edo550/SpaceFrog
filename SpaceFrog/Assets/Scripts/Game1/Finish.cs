

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    public PlayfabManager playfabManager;
    //private AudioSource finishSound;
    public Animator animator;
    //int maxPlatform = 1;
    

    private bool levelCompleted = false;

    private void Start()
    {
        //finishSound = GetComponent<AudioSource>();
        //GameStatic();

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player" && !levelCompleted &&FuelCounterScript.fuelAmount>=100)
        {
            
            //finishSound.Play();
            FuelCounterScript.fuelAmount -= 100;
            
            Destroy(collision.gameObject);
            animator.SetBool("Finish", true);
            levelCompleted = true;
            Invoke("CompleteLevel", 4f);
        }
        else
        {
            NotificationManager.Instance.SetNewNotification("No fuel for takeoff");
        }
    }

    /*
    public void GameStatic(string name)
    { 
        playfabManager.SendLeaderboard(maxPlatform);
    }
    */

    private void CompleteLevel()
    {
        TimerController.instance.EndTimer();
        SceneManager.LoadScene("EndScreen");
    }
}