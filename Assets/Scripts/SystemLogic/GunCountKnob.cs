using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.XRContent.Interaction;
using TMPro;
using UnityEngine.Assertions.Must;

public class GunCountKnob : MonoBehaviour
{
    public bool working;
    public TMP_Text Counter;
    public GameObject myXRKnob; 
    float theValue;

    void Start()
    {
        if (GameManager._me.F5)
        {
            myXRKnob.GetComponent<XRKnob>().Value = Random.Range(0.0f, 0.85f);
        }
        else
        {
            myXRKnob.GetComponent<XRKnob>().Value = 1.0f;
        }
    }

    public void DialLogicTen(float thevValue)
    {
        //theValue = myXRKnob.GetComponent<XRKnob>().Value;
        Debug.Log("Dial value is: " + theValue);

        if(theValue<0.15)
        {
            Counter.text = "10";
        }
        else if(theValue <0.36) 
        {
            Counter.text = "20";
        }
        else if (theValue < 0.5f)
        {
            Counter.text = "50";
        }
        else if (theValue < 0.75f)
        {
            Counter.text = "100";
        }
        else if (theValue < 1.0f)
        {
            Counter.text = "ALL";
        }

        Debug.Log("Counter.text = " + Counter.text);
        working = true;
    }
}
