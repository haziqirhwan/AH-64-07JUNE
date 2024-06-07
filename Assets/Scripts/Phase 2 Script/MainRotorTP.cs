using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainRotorTP : MonoBehaviour
{
    //Canvas Spawning and Teleport Interaction
    public GameObject TPCanvasHelicopter;
    public GameObject TPCanvasHanger;
    public GameObject Player;

    public void Start()
    {
        TPCanvasHelicopter.SetActive(false);
        TPCanvasHanger.SetActive(true);
    }

    public void OnTriggerEnter(Collider other) //find trigger to activate this
    {
        if (other.CompareTag("Player"))
        {
            TPCanvasHelicopter.SetActive(true);
        }
    }

  

    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            TPCanvasHelicopter.SetActive(false);
        }
    }

    public void TeleportToHanger1()
    {
        Vector3 targetPosition = new Vector3(118.56f, 10.55f, -22.7f); // Replace x, y, z with the actual coordinates
        Player.transform.position = targetPosition;
        Debug.Log("Player Teleported to Hanger ");
    }

    public void TeleportBackFromHanger1() //main rotor
    {
        Vector3 targetPosition = new Vector3(71.69f, 8.66f, -60.94f); // Replace x, y, z with the actual coordinates
        Player.transform.position = targetPosition;
        Debug.Log("Player Teleported to Helicopter");
    }

    public void TeleportBackFromHanger2() //tailrotor
    {
        Vector3 targetPosition = new Vector3(66.82f, 7.97f, -65.56f); // Replace x, y, z with the actual coordinates
        Player.transform.position = targetPosition;
        Debug.Log("Player Teleported to Helicopter");
    }

}