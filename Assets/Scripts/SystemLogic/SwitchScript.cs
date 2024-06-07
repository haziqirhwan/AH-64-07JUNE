using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class SwitchScript : MonoBehaviour
{
    public bool On = false;
    public float switchRotation = 100;
    private GameObject Switch;
    public Locks lockSystem; // Reference to the Locks script
    public AudioSource Sound;

    public Timer timer;

    public InputActionProperty TriggerButtonL;
    public InputActionProperty TriggerButtonR;



    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("Its working");
        if ((other.CompareTag("Left Hand") || other.CompareTag("Right Hand")) && /*!timer.CD &&*/ !TriggerButtonL.action.triggered && !TriggerButtonR.action.triggered)
        {
            Debug.Log("Switch Triggered");
            StartCoroutine(timer.Countdown());
            SwitchHit();
            
        }
    }

    void SwitchHit()
    {
        bool previousState = On;
        On = !On; // Use assignment operator '=', not '!='

        if (previousState != On)
        {
            // Move the switch physically
            RotateSwitch();
            Sound.Play();
            // Notify the Locks script that a switch has been toggled
            if(lockSystem)
                lockSystem.SwitchToggled(this);
        }
    }

    void RotateSwitch()
    {
        if (On)
        {
            transform.localRotation = Quaternion.Euler(transform.eulerAngles.x, transform.eulerAngles.y - switchRotation, transform.eulerAngles.z);
        }
        else
        {
            transform.localRotation = Quaternion.Euler(transform.eulerAngles.x, transform.eulerAngles.y + switchRotation, transform.eulerAngles.z);
        }
    }
}