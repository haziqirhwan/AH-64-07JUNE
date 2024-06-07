using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CBsOUT : MonoBehaviour
{
    public CBLogic Logic;
    public GameObject Circuit;
    

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Left Hand") || other.CompareTag("Right Hand"))
        {
            if (Circuit.activeSelf)
                Logic.CBOUT();           
        }
    }
}
