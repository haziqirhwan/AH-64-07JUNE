using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EngineTP : MonoBehaviour
{
    //Canvas Spawning and Teleport Interaction
    public GameObject TPTCanvas;
    public GameObject TPBCanvas;
    public GameObject TPCanvasHelicopter;
    public GameObject TPCanvasHanger;
    public GameObject Player;

    public void Start()
    {
        TPTCanvas.SetActive(false);
        TPBCanvas.SetActive(false);
        TPCanvasHelicopter.SetActive(false);
        TPCanvasHanger.SetActive(true);
    }

    public void OnTriggerEnter(Collider other) //find trigger to activate this
    {
        if(other.CompareTag("Player"))
        {
            TPTCanvas.SetActive(true);
            TPBCanvas.SetActive(true);
            TPCanvasHelicopter.SetActive(true);
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            TPTCanvas.SetActive(false);
            TPBCanvas.SetActive(false);
            TPCanvasHelicopter.SetActive(false);
        }
    } 

    public void TeleportToEngine1()
    {
        Vector3 targetPosition = new Vector3(48.15f, 7.72f, -28.52f); // Replace x, y, z with the actual coordinates
        Player.transform.position = targetPosition;
        Debug.Log("Player Teleported");
    }

    public void TeleportBackFromEngine1()
    {
        Vector3 targetPosition = new Vector3(48.15f, 5.74f, -28.52f); // Replace x, y, z with the actual coordinates
        Player.transform.position = targetPosition;
        Debug.Log("Player Teleported");
    }

    public void TeleportToEngine2()
    {
        Vector3 targetPosition = new Vector3(51.69f, 7.72f, -28.36f); // Replace x, y, z with the actual coordinates
        Player.transform.position = targetPosition;
        Debug.Log("Player Teleported");
    }

    public void TeleportBackFromEngine2()
    {
        Vector3 targetPosition = new Vector3(51.69f, 5.8f, -28.36f); // Replace x, y, z with the actual coordinates
        Player.transform.position = targetPosition;
        Debug.Log("Player Teleported");
    }

    public void TeleportToHanger()
    {
        Vector3 targetPosition = new Vector3(120.27f, 10.78f, -20.7f); // Replace x, y, z with the actual coordinates
        Player.transform.position = targetPosition;
        Debug.Log("Player Teleported");
    }
    public void TeleportBackFromHanger()
    {
        Vector3 targetPosition = new Vector3(72.6f, 7.72f, -62.33f); // Replace x, y, z with the actual coordinates
        Player.transform.position = targetPosition;
        Debug.Log("Player Teleported");
    }
}
