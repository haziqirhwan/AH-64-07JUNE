using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AssessmentResult : MonoBehaviour
{
    public GameObject PWI;
    public GameObject AssessmentCanvas;
    public GameObject ResultCanvas;
    public GameObject Report1stPage;

    public TMP_Text circuitbreaker;
    public TMP_Text hydraulicleak;
    public TMP_Text oilleak;
    public TMP_Text exting;
    public TMP_Text rgun;
    public TMP_Text loader;
    public TMP_Text batt;
    public TMP_Text niu;
    public TMP_Text handpump;
    public TMP_Text hydraulicpress;
    public TMP_Text service;
    public TMP_Text apu;
    public TMP_Text lefab;
    public TMP_Text pin1;
    public TMP_Text pin2;
    public TMP_Text tires;

    void Start()
    {
        if(GameManager._me.IsAssessmentMode)
        {
            PWI.SetActive(false);
            AssessmentCanvas.SetActive(true);
            ResultCanvas.SetActive(true);
            Report1stPage.SetActive(true);
            
        }
        else
        {
            PWI.SetActive(true);
            AssessmentCanvas.SetActive(false);
            ResultCanvas.SetActive(false);
            Report1stPage.SetActive(false);

        }

        // r efab + fire exting, r pylon, r avs, accumulator, l avs, l pylon, l efab (in order )

        // R EFAB +EXTING
        if (GameManager._me.F1 && GameManager._me.I1)
        {
            circuitbreaker.text = "-Circuit Breaker Error Correctly Identified";
        }
        else if (GameManager._me.F1 && !GameManager._me.I1)
        {
            circuitbreaker.text = "-Did not identify Circuit Breakers are popped";
        }
        else if (!GameManager._me.F1 && GameManager._me.I1)
        {
            circuitbreaker.text = "-Misidentified Circuit Breakers are popped";
        }

        // Hydraulic leak
        if (GameManager._me.F2 && GameManager._me.I2)
        {
            hydraulicleak.text = "-Hydraulic Leaks Correctly Identified";
        }
        else if (GameManager._me.F2 && !GameManager._me.I2)
        {
            hydraulicleak.text = "-Did Not Identify Hydraulic Leaks";
        }
        else if (!GameManager._me.F2 && GameManager._me.I2)
        {
            hydraulicleak.text = "-Misidentified Hydraulic Leaks";
        }

        // oilleak
        if (GameManager._me.F3 && GameManager._me.I3)
        {
            oilleak.text = "-Oil Leaks Correctly Identified";
        }
        else if (GameManager._me.F3 && !GameManager._me.I3)
        {
            oilleak.text = "-Did Not Identify Oil Leaks";
        }
        else if (!GameManager._me.F3 && GameManager._me.I3)
        {
            oilleak.text = "-Misidentified Oil Leaks";
        }



        //  Fire Extinguisher
        if (GameManager._me.F8 && GameManager._me.I8)
        {
            exting.text = "-Extinguisher missing Correctly Identified";
        }
        else if (GameManager._me.F8 && !GameManager._me.I8)
        {
            exting.text = "-Did Not Identify missing Extinguisher";
        }
        else if (!GameManager._me.F8 && GameManager._me.I8)
        {
            exting.text = "-Misidentified Extinguisher as missing";
        }

        if (GameManager._me.F7 && GameManager._me.I7)
        {
            exting.text = "-Extinguisher Correctly Identified as expired";
        }
        else if (GameManager._me.F7 && !GameManager._me.I7)
        {
            exting.text = "-Did Not Identify expired Extinguisher";
        }
        else if (!GameManager._me.F7 && GameManager._me.I7)
        {
            exting.text = "-Misidentified Extinguisher as expired";
        }

        //Rgun
        if (GameManager._me.F5 && GameManager._me.I5)
        {
            rgun.text = "-Gun Count Error Correctly Identified";
        }
        else if (GameManager._me.F5 && !GameManager._me.I5)
        {
            rgun.text = "-Incorrect Settings for Gun Counr";
        }
        else if (!GameManager._me.F5 && GameManager._me.I5)
        {
            rgun.text = "-Misidentified Gun Count is in the correct setting";
        }

        //r loader clutch
        if (GameManager._me.F6 && GameManager._me.I6)
        {
            loader.text = "-Loader Clutch correctly identified not secured";
        }
        else if (GameManager._me.F6 && !GameManager._me.I6)
        {
            loader.text = "-Did Not Identify Insecured Loader Clutch";
        }
        else if (!GameManager._me.F6 && GameManager._me.I6)
        {
            loader.text = "-Misidentified not Secured Loader Clutch";
        }

        //battery
        if (GameManager._me.F9 && GameManager._me.I9)
        {
            batt.text = "-Correctly identified Battery not latched";
        }
        else if (GameManager._me.F9 && !GameManager._me.I9)
        {
            batt.text = "-Did not identify Battery not latched";
        }
        else if (!GameManager._me.F9 && GameManager._me.I9)
        {
            batt.text = "-Misidentified Battery is already latched";
        }

        //niu
        if (GameManager._me.F10 && GameManager._me.I10)
        {
            niu.text = "-Correctly Identified Faulty NIU";
        }
        else if (GameManager._me.F10 && !GameManager._me.I10)
        {
            niu.text = "-Did not Identify NIU Faulty Indications";
        }
        else if (!GameManager._me.F10 && GameManager._me.I10)
        {
            niu.text = "-Misidentified NIU Indications";
        }

        //handpump
        if (GameManager._me.F11 && GameManager._me.I11)
        {
            handpump.text = "Correctly Indentified Accumulator Handpump not secured";
        }
        else if (GameManager._me.F11 && !GameManager._me.I11)
        {
            handpump.text = "-Did not Identify unsecured Accumulator Handpump";
        }
        else if (!GameManager._me.F11 && GameManager._me.I11)
        {
            handpump.text = "-Misidentified Accumulator Handpump as not secured";
        }

        //hydraulic pressure
        if (GameManager._me.F12 && GameManager._me.I12)
        {
            hydraulicpress.text = "Accumulator Hydraulic Pressure Correctly Identified";
        }
        else if (GameManager._me.F12 && !GameManager._me.I12)
        {
            hydraulicpress.text = "-Did not Identify Hydraulic Pressure is Below 1650psi";
        }
        else if (!GameManager._me.F12 && GameManager._me.I12)
        {
            hydraulicpress.text = "-Misidentified Hydraulic Pressure and is within limits";
        }

        //service dip
        if (GameManager._me.F13 && GameManager._me.I13)
        {
            service.text = "No Errors for Service Dip";
        }
        else if (GameManager._me.F13 && !GameManager._me.I13)
        {
            service.text = "-Service Dip <minimum";
        }
        else if (!GameManager._me.F13 && GameManager._me.I13)
        {
            service.text = "-Service Dip >minimum";
        }

        //pop pin
        if (GameManager._me.F14 && GameManager._me.I14)
        {
            pin1.text = "Correctly Identified Pop Pins for Eng 1";
        }
        else if (GameManager._me.F14 && !GameManager._me.I14)
        {
            pin1.text = "-Did not identify Pop Pins for Eng 1";
        }
        else if (!GameManager._me.F14 && GameManager._me.I14)
        {
            pin1.text = "-Misidentified Pop Pins for Eng 1";
        }

        if (GameManager._me.F15 && GameManager._me.I15)
        {
            pin2.text = "Correctly Identified Pop Pins for Eng 2";
        }
        else if (GameManager._me.F15 && !GameManager._me.I15)
        {
            pin2.text = "-Did not identify Pop Pins for Eng 2";
        }
        else if (!GameManager._me.F15 && GameManager._me.I15)
        {
            pin2.text = "-Misidentified Pop Pins for Eng 2";
        }

        //flat tire
        if (GameManager._me.F16 && GameManager._me.I16)
        {
            tires.text = "Correctly Identified Deflated Tyre";
        }
        else if (GameManager._me.F16 && !GameManager._me.I16)
        {
            tires.text = "-Did not identify Deflated Tyres";
        }
        else if (!GameManager._me.F16 && GameManager._me.I16)
        {
            tires.text = "-Misidentified Tyres as deflated";
        }

        //APU oil sight
        if (GameManager._me.F4 && GameManager._me.I4)
        {
            apu.text = "Correctly Identified APU Oilsight";
        }
        else if (GameManager._me.F4 && !GameManager._me.I4)
        {
            apu.text = "-Did not Identify APU Oilsight Issues";
        }
        else if (!GameManager._me.F4 && GameManager._me.I4)
        {
            apu.text = "-Misidentified APU Oilsight";
        }

        //lefab
        /*if (GameManager._me.F17 && GameManager._me.I17)
        {
            lefab.text = "No Errors for L Circuir Breakers";
        }
        else if (GameManager._me.F17 && !GameManager._me.I17)
        {
            lefab.text = "-Left Circuit Breakers still popped";
        }
        else if (!GameManager._me.F17 && GameManager._me.I17)
        {
            lefab.text = "- Left Circuit Breakers were normal";
        }
        */
    }
}


