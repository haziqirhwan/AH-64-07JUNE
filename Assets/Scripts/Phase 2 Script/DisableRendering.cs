using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;

public class DisableRendering : MonoBehaviour
{
    public GameObject Player;
    public List<GameObject> RenderingOff = new List<GameObject>();
    


    void Start()
    {
      
    }

    public void OnTriggerEnter(Collider other) //find trigger to activate this
    {
        if (other.CompareTag("Player") && GameManager._me.TutorialVoiceTrigger == false && GameManager._me.IsTutorialMode == true)
        {

            for (int i = 0; i < RenderingOff.Count; i++)
            {

                RenderingOff[i].SetActive(false);

            }

        }

    }
    public void OnTriggerExit(Collider other) //disable when leaving the area
    {
        if (other.CompareTag("Player") && GameManager._me.TutorialVoiceTrigger == false && GameManager._me.IsTutorialMode == true)
        {
            for (int i = 0; i < RenderingOff.Count; i++)
            {

                RenderingOff[i].SetActive(true);

            }
        }


    }
}
