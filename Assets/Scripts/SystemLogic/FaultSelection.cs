using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FaultSelection : MonoBehaviour
{   public void CurrentModeTutorial()
    {
        GameManager._me.IsTutorialMode = true;
        Debug.Log("TutBoolSetTrue");
    }

    public void TutorialOFF()
    {
        GameManager._me.IsTutorialMode = false;
        Debug.Log("TutBoolSetFalse");
    }

    //Fault Assessment Mode
    public void FaultAssessment(bool IsAssessmentMode)
    {
        GameManager._me.IsAssessmentMode = !GameManager._me.IsAssessmentMode;
        Debug.Log("IsAssessmentMode Toggled");
    }
    public void AssessmentOff()
    {
        if (GameManager._me.IsAssessmentMode == true)
        {
            GameManager._me.IsAssessmentMode = false;
            Debug.Log("IsAssessmentMode Set False");
        }
    }

    //Fault 1 Settings
    public void F1Settings(bool F1Bool) //allows Toggle in menu
    {
        GameManager._me.F1 = !GameManager._me.F1;
        Debug.Log("F1Toggled");
    }
    public void F1off() //force set 0 in bool
    {
        if(GameManager._me.F1 == true)
        {
            GameManager._me.F1 = false;
            Debug.Log("F1 Set False");
        }
    }

    //Fault 2 Settings
    public void F2Settings(bool F2Bool)
    {
        GameManager._me.F2 = !GameManager._me.F2;
        Debug.Log("F2Toggled");
    }
    public void F2off()
    {
        if (GameManager._me.F2 == true)
        {
            GameManager._me.F2 = false;
            Debug.Log("F2 Set False");
        }
    }

            //Fault 3 Settings
    public void F3Settings(bool F3Bool)
    {
        GameManager._me.F3 = !GameManager._me.F3;
        Debug.Log("F3Toggled");
    }
    public void F3off()
    {
        if (GameManager._me.F3 == true)
        {
            GameManager._me.F3 = false;
            Debug.Log("F3 Set False");
        }
    }

    //Fault 4 Settings
    public void F4Settings(bool F4Bool)
    {
        GameManager._me.F4 = !GameManager._me.F4;
        Debug.Log("F4Toggled");
    }
    public void F4off()
    {
        if (GameManager._me.F4 == true)
        {
            GameManager._me.F4 = false;
            Debug.Log("F4 Set False");
        }
    }

    //Fault 5 Settings
    public void F5Settings(bool F5Bool)
    {
        GameManager._me.F5 = !GameManager._me.F5;
        Debug.Log("F5Toggled");
    }
    public void F5off()
    {
        if (GameManager._me.F5 == true)
        {
            GameManager._me.F5 = false;
            Debug.Log("F5 Set False");
        }
    }


    //Fault 6 Settings
    public void F6Settings(bool F6Bool)
    {
        GameManager._me.F6 = !GameManager._me.F6;
        Debug.Log("F6Toggled");
    }
    public void F6off()
    {
        if (GameManager._me.F6 == true)
        {
            GameManager._me.F6 = false;
            Debug.Log("F6 Set False");
        }
    }

    //Fault 7 Settings
    public void F7Settings(bool F7Bool)
    {
        GameManager._me.F7 = !GameManager._me.F7;
        Debug.Log("F7Toggled");
    }
    public void F7off()
    {
        if (GameManager._me.F7 == true)
        {
            GameManager._me.F7 = false;
            Debug.Log("F7 Set False");
        }
    }

    //Fault 8 Settings
    public void F8Settings(bool F8Bool)
    {
        GameManager._me.F8 = !GameManager._me.F8;
        Debug.Log("F8Toggled");
    }
    public void F8off()
    {
        if (GameManager._me.F8 == true)
        {
            GameManager._me.F8 = false;
            Debug.Log("F8 Set False");
        }
    }

    //Fault 9 Settings
    public void F9Settings(bool F9Bool)
    {
        GameManager._me.F9 = !GameManager._me.F9;
        Debug.Log("F9Toggled");
    }
    public void F9off()
    {
        if (GameManager._me.F9 == true)
        {
            GameManager._me.F9 = false;
            Debug.Log("F9 Set False");
        }
    }

    //Fault 10 Settings
    public void F10Settings(bool F10Bool)
    {
        GameManager._me.F10 = !GameManager._me.F10;
        Debug.Log("F10Toggled");
    }
    public void F10off()
    {
        if (GameManager._me.F10 == true)
        {
            GameManager._me.F10 = false;
            Debug.Log("F10 Set False");
        }
    }

    //Fault 11 Settings
    public void F11Settings(bool F11Bool)
    {
        GameManager._me.F11 = !GameManager._me.F11;
        Debug.Log("F11Toggled");
    }
    public void F11off()
    {
        if (GameManager._me.F11 == true)
        {
            GameManager._me.F11 = false;
            Debug.Log("F11 Set False");
        }
    }

    //Fault 12 Settings
    public void F12Settings(bool F12Bool)
    {
        GameManager._me.F12 = !GameManager._me.F12;
        Debug.Log("F12Toggled");
    }
    public void F12off()
    {
        if (GameManager._me.F12 == true)
        {
            GameManager._me.F12 = false;
            Debug.Log("F12 Set False");
        }
    }

    //Fault 13 Settings
    public void F13Settings(bool F13Bool)
    {
        GameManager._me.F13 = !GameManager._me.F13;
        Debug.Log("F13Toggled");
    }
    public void F13off()
    {
        if (GameManager._me.F13 == true)
        {
            GameManager._me.F13 = false;
            Debug.Log("F13 Set False");
        }
    }

    //Fault 14 Settings
    public void F14Settings(bool F14Bool)
    {
        GameManager._me.F14 = !GameManager._me.F14;
        Debug.Log("F14Toggled");
    } 
    public void F14off()
    {
        if (GameManager._me.F14 == true)
        {
            GameManager._me.F14 = false;
            Debug.Log("F14 Set False");
        }
    }

    //Fault 15 Settings
    public void F15Settings(bool F15Bool)
    {
        GameManager._me.F15 = !GameManager._me.F15;
        Debug.Log("F15Toggled");
    }
    public void F15off()
    {
        if (GameManager._me.F15 == true)
        {
            GameManager._me.F15 = false;
            Debug.Log("F15 Set False");
        }
    }

    public void F16Settings(bool F16Bool)
    {
        GameManager._me.F16 = !GameManager._me.F16;
        Debug.Log("F16Toggled");
    }
    public void F16off()
    {
        if (GameManager._me.F16 == true)
        {
            GameManager._me.F16 = false;
            Debug.Log("F16 Set False");
        }
    }

    public void F17Settings(bool F17Bool)
    {
        GameManager._me.F17 = !GameManager._me.F17;
        Debug.Log("F17Toggled");
    }
    public void F17off()
    {
        if (GameManager._me.F17 == true)
        {
            GameManager._me.F17 = false;
            Debug.Log("F17 Set False");
        }
    }
}
