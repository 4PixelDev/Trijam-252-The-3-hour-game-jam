using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDownTimeSystem : MonoBehaviour
{
    public float countdownTime = 60f;
    private float currentTime;

    public Text countdownText; // Reference to a UI text element for displaying the countdown.

    void Start()
    {
        currentTime = countdownTime;
        UpdateCountdownText();
    }

    void Update()
    {
        if (currentTime > 0)
        {
            UpdateCountdown();
        }
        else
        {
            // Handle when the countdown reaches zero, for example, end the game or take appropriate actions.
        }
    }

    void UpdateCountdown()
    {
        currentTime -= Time.deltaTime;
        UpdateCountdownText();
    }

    void UpdateCountdownText()
    {
        // Update the UI text with the current countdown time.
        if (countdownText != null)
        {
            countdownText.text = Mathf.CeilToInt(currentTime).ToString();
        }
    }
}
