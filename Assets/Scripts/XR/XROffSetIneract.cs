using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class XROffSetIneract : XRGrabInteractable
{
    private Vector3 initalPos;
    private Quaternion initalRot;

    // Start is called before the first frame update
    void Start()
    {
        if(!attachTransform)
        {
            GameObject attachPoint = new GameObject("Offset Grab Pivot");
            attachPoint.transform.SetParent(transform, false);
            attachTransform = attachPoint.transform;
        }
        else 
        {
            initalPos = attachTransform.localPosition;
            initalRot = attachTransform.localRotation;
        }
    }

    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        if(args.interactorObject is XRDirectInteractor)
        {
            attachTransform.position = args.interactorObject.transform.position;
            attachTransform.rotation = args.interactorObject.transform.rotation;

        }
        else
        {
            attachTransform.localPosition = initalPos;
            attachTransform.rotation = initalRot;
        } 
        base.OnSelectEntered(args);
    }
}
