using System.Collections;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float Interval = 1.51f; // Set the interval in seconds
    private float currentTime;
    public bool CD = false;


    public IEnumerator Countdown()
    {
        CD = true;
        currentTime = Interval;

        while (currentTime > 0)
        {
            currentTime -= Time.deltaTime;
            Debug.Log($"CurrentTime is {currentTime:F2}");

            yield return null;
        }
        Debug.Log($"Countdown finished");
        CD = false;

    }
}