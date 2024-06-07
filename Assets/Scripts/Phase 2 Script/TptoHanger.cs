using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TptoHanger : MonoBehaviour
{
    //Canvas Spawning and Teleport Interaction
    public GameObject TPCanvasHelicopterToHanger;
    public GameObject TPCanvasHangerToHelicopter;
    public GameObject Player;

    public void Start()
    {
        TPCanvasHelicopterToHanger.SetActive(false);
        TPCanvasHangerToHelicopter.SetActive(false);
    }

    public void OnTriggerEnter(Collider other) //find trigger to activate this
    {
        if (other.CompareTag("Player"))
        {
            TPCanvasHelicopterToHanger.SetActive(true);
            TPCanvasHangerToHelicopter.SetActive(true);
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            TPCanvasHelicopterToHanger.SetActive(false);
            TPCanvasHangerToHelicopter.SetActive(false);
        }
    }

    public void TeleportToEngine1()
    {
        Vector3 targetPosition = new Vector3(51.92f, 5.95f, 16.54f); // Replace x, y, z with the actual coordinates
        Player.transform.position = targetPosition;
        Player.transform.rotation = Quaternion.Euler(0,151.45f,0);
        //Debug.Log("Player Teleported");
    }

    public void TeleportBackFromEngine1()
    {
        Vector3 targetPosition = new Vector3(46.28f, 5.95f, -20.01f); // Replace x, y, z with the actual coordinates
        Player.transform.position = targetPosition;
        Player.transform.rotation = Quaternion.Euler(0,118.48f,0);
        Debug.Log("Player Teleported");
    }

    public void TeleportToEngine2()
    {
        Vector3 targetPosition = new Vector3(73.22f, 7.39f, -62.69f); // Replace x, y, z with the actual coordinates
        Player.transform.position = targetPosition;
        Debug.Log("Player Teleported");
    }

    public void TeleportBackFromEngine2()
    {
        Vector3 targetPosition = new Vector3(72.805f, 5.8f, -62.89f); // Replace x, y, z with the actual coordinates
        Player.transform.position = targetPosition;
        Debug.Log("Player Teleported");
    }
}