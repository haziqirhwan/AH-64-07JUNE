using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaySwitch : MonoBehaviour
{
    public GameObject RayInteractor;
    public GameObject TurnonCanvasRay;
    public GameObject TurnoffCanvasRay;

    // Start is called before the first frame update
    void Start()
    {
        RayInteractor.SetActive(false);
        TurnonCanvasRay.SetActive(true);
        TurnoffCanvasRay.SetActive(false);


    }

    public bool working;


    void Update()
    {


    }

    // Update is called once per frame
    public void Clickon()
    {
        RayInteractor.SetActive(true);
        Debug.Log("RayInteractor ON Pressed");
        working = true;
        TurnonCanvasRay.SetActive(false);
        TurnoffCanvasRay.SetActive(true);

    }

    public void Clickoff()
    {
        RayInteractor.SetActive(false);
        Debug.Log("RayInteractor OFF Pressed");
        working = false;
        TurnonCanvasRay.SetActive(true);
        TurnoffCanvasRay.SetActive(false);

    }
}
