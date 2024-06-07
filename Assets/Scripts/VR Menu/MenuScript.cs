using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MenuScript : MonoBehaviour
{
    public Transform head;
    public float spawnDist = 2;
    public GameObject menu;
    public InputActionProperty showbutton;
  

    void Update()
    {
        if(showbutton.action.WasPressedThisFrame())
        {
            Debug.Log("Menu Button Pressed");
            menu.SetActive(!menu.activeSelf);
            menu.transform.position = head.position + new Vector3(head.forward.x, 0, head.forward.z).normalized * spawnDist;
        }
        menu.transform.LookAt(new Vector3(head.position.x, menu.transform.position.y, head.position.z));
        menu.transform.forward *= -1;
    }

    // This method will be called when the button is pressed
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Application Quit");
    }

}
