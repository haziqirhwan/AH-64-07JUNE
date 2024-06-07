using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AnimateHandOnInput : MonoBehaviour
{
    public InputActionProperty pinchAnimatetionAction;
    public InputActionProperty gripAnimatetionAction;
    public Animator handAnimator;
    void Start()
    {
        
    }

    
    void Update()
    {
       float triggervalue = pinchAnimatetionAction.action.ReadValue<float>();
       handAnimator.SetFloat("Trigger", triggervalue);
        
       float gripvalue = gripAnimatetionAction.action.ReadValue<float>();
       handAnimator.SetFloat("Grip", gripvalue);
    }
}
