using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invisible : MonoBehaviour
{

    public GameObject cube;

    // Start is called before the first frame update
    public void ToggleVisibility()
    {
        // Check if the cube exists
        if (cube != null)
        {
            // Toggle the visibility by enabling/disabling the renderer component
            Renderer renderer = cube.GetComponent<Renderer>();
            if (renderer != null)
            {
                renderer.enabled = !renderer.enabled;
            }
        }
    }
}

