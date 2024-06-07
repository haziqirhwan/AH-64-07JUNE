using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class RandomizeToggle : MonoBehaviour
{
    public Toggle toggle1, toggle2, toggle3, toggle4, toggle5, toggle6, toggle7, toggle8, toggle9, toggle10, toggle11, toggle12, toggle13, toggle14, toggle15, toggle16;
    public void ToggleSelection()
    {
        // doing for toggle1
        if (Random.Range(0, 2) == 0)
        {
            toggle1.isOn = true;
        }
        else
        {
            toggle1.isOn = false;
        }

        //doing for toggle2
        if (Random.Range(0, 2) == 0)
        {
            toggle2.isOn = true;
        }
        else
        {
            toggle2.isOn = false;
        }
        //doing for toggle3
        if (Random.Range(0, 2) == 0)
        {
            toggle3.isOn = true;
        }
        else
        {
            toggle3.isOn = false;
        }
        //doing for toggle4
        if (Random.Range(0, 2) == 0)
        {
            toggle4.isOn = true;
        }
        else
        {
            toggle4.isOn = false;
        }
        //doing for toggle5
        if (Random.Range(0, 2) == 0)
        {
            toggle5.isOn = true;
        }
        else
        {
            toggle5.isOn = false;
        }
        //doing for toggle6
        if (Random.Range(0, 2) == 0)
        {
            toggle6.isOn = true;
        }
        else
        {
            toggle6.isOn = false;
        }
        //doing for toggle7
        if (Random.Range(0, 2) == 0)
        {
            toggle7.isOn = true;
        }
        else
        {
            toggle7.isOn = false;
        }
        //doing for toggle8
        if (Random.Range(0, 2) == 0)
        {
            toggle8.isOn = true;
        }
        else
        {
            toggle8.isOn = false;
        }

        if (Random.Range(0, 2) == 0)
        {
            toggle9.isOn = true;
        }
        else
        {
            toggle9.isOn = false;
        }

        if (Random.Range(0, 2) == 0)
        {
            toggle10.isOn = true;
        }
        else
        {
            toggle10.isOn = false;
        }

        if (Random.Range(0, 2) == 0)
        {
            toggle11.isOn = true;
        }
        else
        {
            toggle11.isOn = false;
        }

        if (Random.Range(0, 2) == 0)
        {
            toggle12.isOn = true;
        }
        else
        {
            toggle12.isOn = false;
        }

        if (Random.Range(0, 2) == 0)
        {
            toggle13.isOn = true;
        }
        else
        {
            toggle13.isOn = false;
        }

        if (Random.Range(0, 2) == 0)
        {
            toggle14.isOn = true;
        }
        else
        {
            toggle14.isOn = false;
        }

        if (Random.Range(0, 2) == 0)
        {
            toggle15.isOn = true;
        }
        else
        {
            toggle15.isOn = false;
        }

        if (Random.Range(0, 2) == 0)
        {
            toggle16.isOn = true;
        }
        else
        {
            toggle16.isOn = false;
        }

        /*if (Random.Range(0, 2) == 0)
        {
            toggle17.isOn = true;
        }
        else
        {
            toggle17.isOn = false;
        }*/
    }
}

