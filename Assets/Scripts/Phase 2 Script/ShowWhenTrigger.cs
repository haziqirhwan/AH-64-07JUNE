using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowWhenTrigger : MonoBehaviour
{
    //public GameObject introCanvas;
    public GameObject Trigger;
    public List<GameObject> introCanvas = new List<GameObject>();

    private void Start()
    {
        for (int i = 0; i < introCanvas.Count; i++)
        {
            introCanvas[i].SetActive(false);
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        GameManager._me.InsideTrigger = true;
        // Check if the object entering the trigger is the player or another relevant object
        if (other.CompareTag("Player") &&  GameManager._me.IsTutorialMode == true)
        {
            for (int i = 0; i < introCanvas.Count; i++)
            {


                introCanvas[i].SetActive(true);

            }
        }
    }

    public void OnTriggerExit(Collider other)
    {
        GameManager._me.InsideTrigger = false;
        for (int i = 0; i < introCanvas.Count; i++)
        {
            introCanvas[1].SetActive(false);

        }
        
    }

   
}

