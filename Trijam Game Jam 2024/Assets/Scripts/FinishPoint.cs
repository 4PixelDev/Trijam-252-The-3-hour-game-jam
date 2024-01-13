using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishPoint : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player Reached The Finish Point");
            // play finish point sound 
            // maybeee play animation
            // load the next scene after amount of time.. for example just 3 sec
        }
    }
}
