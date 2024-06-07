using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AttachButtonToHand : MonoBehaviour
{
    public Transform handTransform; // Reference to the hand's Transform
    public GameObject toggleButton; // Reference to the toggle button GameObject

    void Start()
    {
        if (handTransform != null && toggleButton != null)
        {
            // Set the toggle button's parent to the hand
            toggleButton.transform.SetParent(handTransform, false);
            // Optionally, set an offset if needed
            toggleButton.transform.localPosition = new Vector3(-0.018f, 0.07f, -0.1f);
            toggleButton.transform.localRotation = Quaternion.identity;
        }
    }
}