using System.Collections;
using UnityEngine;

public class CBLogic : MonoBehaviour
{
    public GameObject NormalCB;
    public GameObject CircuitBreakers;


    public AudioSource ClickIn;
    public AudioSource ClickOut;

    public FaultRandomize FaultRandomize;

    public Timer timer; // Reference to the Timer script

    private int activeIndex; // Store the active index

    public void CBIN()
    {
        if (NormalCB.activeSelf && !timer.CD)
        {
            NormalCB.SetActive(false);
            StartCoroutine(timer.Countdown());
            CircuitBreakers.SetActive(true);
            ClickIn.Play();

            // FaultRandomize.UpdateCircuitBreakerState(activeIndex, true);

            Debug.Log("Circuit Pulled Out");
        }
    }

    public void CBOUT()
    {
      if (CircuitBreakers.activeSelf && !timer.CD)
      {
                NormalCB.SetActive(true);
                // Start the countdown using Timer
                StartCoroutine(timer.Countdown());
                CircuitBreakers.SetActive(false);
                ClickOut.Play();

                //  FaultRandomize.UpdateCircuitBreakerState(activeIndex, false);

                Debug.Log("Circuit Pushed In");
      }
    }
}