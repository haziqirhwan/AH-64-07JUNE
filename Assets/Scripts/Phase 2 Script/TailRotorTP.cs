using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TailRotorTP : MonoBehaviour
{
    //Canvas Spawning and Teleport Interaction
    public GameObject TPCanvasHelicopterTail;
    public GameObject TPCanvasHangerTail;
    public GameObject Player;

    public void Start()
    {
        TPCanvasHelicopterTail.SetActive(false);
        TPCanvasHangerTail.SetActive(true);
    }

    public void OnTriggerEnter(Collider other) //find trigger to activate this
    {
        if (other.CompareTag("Player"))
        {
            TPCanvasHelicopterTail.SetActive(true);
        }
    }



    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            TPCanvasHelicopterTail.SetActive(false);
        }
    }

    public void TeleportToHangerTail()
    {
        Vector3 targetPosition = new Vector3(118.56f, 10.55f, -22.7f); // Replace x, y, z with the actual coordinates
        Player.transform.position = targetPosition;
        Debug.Log("Player Teleported to Hanger ");
    }

    public void TeleportBackFromHangerTail()
    {
        Vector3 targetPosition = new Vector3(72.6f, 7.72f, -62.33f); // Replace x, y, z with the actual coordinates
        Player.transform.position = targetPosition;
        Debug.Log("Player Teleported to Helicopter");
    }

    public void TeleportBacktoTail()
    {
        Vector3 targetPosition = new Vector3(66.82f, 7.97f, -65.56f); // Replace x, y, z with the actual coordinates
        Player.transform.position = targetPosition;
        Debug.Log("Player Teleported to Helicopter");
    }

}