using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class DisappearOnClickVR : MonoBehaviour //FOD
{
    public GameObject Correct; 
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Right Hand"))
                {
            Debug.Log("colide");
            // Hide the object
            gameObject.SetActive(false);
            Correct.SetActive(true);

        }

    }

}