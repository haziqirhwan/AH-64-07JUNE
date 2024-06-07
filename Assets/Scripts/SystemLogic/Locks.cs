using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Locks : MonoBehaviour
{
    //Main Locking System
    public GameObject DoorHandle;
    public List<SwitchScript> SwitchList; // List of all switches
    public Rigidbody DoorRigidbody;

    //Reporting Canvas Spawning
    public GameObject ReportCanvas;
    public GameObject LabelCanvas;

    //GCB Label
    public GameObject GCBCanvas;

    //Date Canvas for Fire Extinguisher
    public GameObject FireExtinguisherDateCanvasExpired;
    public GameObject FireExtinguisherDateCanvasNotExpired;

    //Accumulator Door
    public GameObject AccumulatorCanvas;
    public GameObject AccumulatorDoor;
    public float DoorRotation = 100;
    

    private bool LockedState = true;

    void Start()
    {
        LockedState = true;
        DoorHandle.SetActive(false);

        if (LabelCanvas != null)
        {
            LabelCanvas.SetActive(false);
        }

        if(ReportCanvas != null)
        {
            ReportCanvas.SetActive(false);
        }
 

        if (FireExtinguisherDateCanvasExpired != null && FireExtinguisherDateCanvasNotExpired != null)
        {
            FireExtinguisherDateCanvasExpired.SetActive(false);
            FireExtinguisherDateCanvasNotExpired.SetActive(false);
        }


        if (AccumulatorDoor != null)
        {
            AccumulatorDoor.SetActive(true);
        }

        if (AccumulatorCanvas != null)
        { 
            AccumulatorCanvas.SetActive(false);
        }


        if (GCBCanvas != null)
        {
            GCBCanvas.SetActive(false);
        }

    }

    // Method to be called when a switch is toggled
    public void SwitchToggled(SwitchScript toggledSwitch)
    {
        // Check if all switches are on
        if (AreAllSwitchesOn())
        {
            UnlockDoor();
        }
        else
        {
            // If any switch is off, lock the door
            LockDoor();
        }
    }

    bool AreAllSwitchesOn()
    {
        // Check the state of each switch
        foreach (var switchScript in SwitchList)
        {
            if (!switchScript.On)
            {
                return false;
            }
        }

        return true;
    }

    void UnlockDoor()
    {
        LockedState = false;

        if (!LockedState)
        {
            // Activate the door handle
            DoorHandle.SetActive(true);
          //  DoorRigidbody.useGravity = true; //to be reduced 

            if(GameManager._me.InsideTrigger == true && GameManager._me.IsAssessmentMode == true) //Set Reporting Canvas Active
            {
                ReportCanvas.SetActive(true);
                Debug.Log("Reporting Canvas Active " + ReportCanvas.name);
            }
            else if(GameManager._me.InsideTrigger == true && GameManager._me.IsTutorialMode == true) //Set Label Canvas Active
            {
                LabelCanvas.SetActive(true);
                Debug.Log("Label Canvas Active " + LabelCanvas.name);
            }

            Debug.Log("Door Unlocked");

            if(GameManager._me.InsideTrigger == true && GCBCanvas !=null)
            { 
                  GCBCanvas.SetActive(true);
            }

            if (GameManager._me.F7 && FireExtinguisherDateCanvasExpired != null && FireExtinguisherDateCanvasNotExpired != null) //Set Extinguisher Label Canvas if not null, Since each door will use this script, put the extinguisher on the respective door else leave null
                FireExtinguisherDateCanvasExpired.SetActive(true);
            else if(!GameManager._me.F7 && FireExtinguisherDateCanvasExpired != null && FireExtinguisherDateCanvasNotExpired != null)
                FireExtinguisherDateCanvasNotExpired.SetActive(true);

            if(GameManager._me.InsideTrigger == true && AccumulatorDoor != null) //Same Logic for the extinguisher, idea is if rear right avionics pylon bay door is unlocked, acc door will also be opnened
            {
                OpenAccumulatorDoor();
                AccumulatorCanvas.SetActive(true);
                
            }
        }
    }

    void LockDoor()
    {
        LockedState = true;

        // Deactivate the door handle
        DoorHandle.SetActive(false);
       // DoorRigidbody.useGravity = false;

        LabelCanvas.SetActive(false);
        ReportCanvas.SetActive(false);
        Debug.Log("Canvas Deactive");
        
        if(GameManager._me.F7 && FireExtinguisherDateCanvasExpired != null && FireExtinguisherDateCanvasNotExpired != null)
        {
            FireExtinguisherDateCanvasExpired.SetActive(false);
            FireExtinguisherDateCanvasNotExpired.SetActive(false);
        }

        if (GameManager._me.InsideTrigger == true && GCBCanvas != null)
        {
            GCBCanvas.SetActive(false);
        }

        if (GameManager._me.InsideTrigger == true && AccumulatorDoor != null)
        {
            CloseAccumulatorDoor();
            AccumulatorCanvas.SetActive(false);
        }

        Debug.Log("Door Locked");
    }

    void OpenAccumulatorDoor()
    {
        AccumulatorDoor.SetActive(false);
        //transform.rotation = Quaternion.Euler(transform.eulerAngles.x - DoorRotation, transform.eulerAngles.y, transform.eulerAngles.z);  
    }

    void CloseAccumulatorDoor()
    {
        AccumulatorDoor.SetActive(true);
        //transform.rotation = Quaternion.Euler(transform.eulerAngles.x + DoorRotation, transform.eulerAngles.y, transform.eulerAngles.z);
    }
}