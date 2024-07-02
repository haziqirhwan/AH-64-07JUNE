using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Open_Close : MonoBehaviour
{
    public Animator mAnimator;
    public bool Open_bool;
    public GameObject open;
    public GameObject close;

    // Start is called before the first frame update
    void Start()
    {
       // mAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    public void ToggleDoor1()
    {
        if (mAnimator != null)
        {
            if (!Open_bool)
            {
                mAnimator.SetTrigger("TrOpen");
                Debug.Log("Door Open");
                Open_bool = true;
                //ButtonOpen();
            }
            else
            {
                mAnimator.SetTrigger("TrClose");
                Debug.Log("Door Close");
                Open_bool = false;
                //ButtonClose();
            }
        }
    }

    public void ToggleDoor2()
    {
        if (mAnimator != null)
        {
            if (!Open_bool)
            {
                mAnimator.SetTrigger("Tr2Open");
                Debug.Log("Door Open");
                Open_bool = true;
            }
            else
            {
                mAnimator.SetTrigger("Tr2Close");
                Open_bool = false;

            }
        }
    }

    public void ToggleDoor3()
    {
        if (mAnimator != null)
        {
            if (!Open_bool)
            {
                mAnimator.SetTrigger("Tr3Open");
                Debug.Log("Door Open");
                Open_bool = true;
            }
            else
            {
                mAnimator.SetTrigger("Tr3Close");
                Open_bool = false;

            }
        }
    }

    public void ToggleDoor4()
    {
        if (mAnimator != null)
        {
            if (!Open_bool)
            {
                mAnimator.SetTrigger("Tr4Open");
                Debug.Log("Door Open");
                Open_bool = true;
            }
            else
            {
                mAnimator.SetTrigger("Tr4Close");
                Open_bool = false;

            }
        }

    }

    public void ToggleDoor5()
    {
        if (mAnimator != null)
        {
            if (!Open_bool)
            {
                mAnimator.SetTrigger("Tr5Open");
                Debug.Log("Door Open");
                Open_bool = true;
            }
            else
            {
                mAnimator.SetTrigger("Tr5Close");
                Open_bool = false;

            }
        }

    }

    public void ToggleDoor6()
    {
        if (mAnimator != null)
        {
            if (!Open_bool)
            {
                mAnimator.SetTrigger("Tr6Open");
                Debug.Log("Door Open");
                Open_bool = true;
            }
            else
            {
                mAnimator.SetTrigger("Tr6Close");
                Open_bool = false;

            }
        }

    }

    public void ToggleDoor7()
    {
        if (mAnimator != null)
        {
            if (!Open_bool)
            {
                mAnimator.SetTrigger("Tr7Open");
                Debug.Log("Door Open");
                Open_bool = true;
            }
            else
            {
                mAnimator.SetTrigger("Tr7Close");
                Open_bool = false;

            }
        }

    }

    public void ToggleDoor8()
    {
        if (mAnimator != null)
        {
            if (!Open_bool)
            {
                mAnimator.SetTrigger("Tr8Open");
                Debug.Log("Door Open");
                Open_bool = true;
            }
            else
            {
                mAnimator.SetTrigger("Tr8Close");
                Open_bool = false;

            }
        }

    }

    public void ToggleDoor9()
    {
        if (mAnimator != null)
        {
            if (!Open_bool)
            {
                mAnimator.SetTrigger("Tr9Open");
                Debug.Log("Door Open");
                Open_bool = true;
            }
            else
            {
                mAnimator.SetTrigger("Tr9Close");
                Open_bool = false;

            }
        }

    }

    public void ToggleDoor10()
    {
        if (mAnimator != null)
        {
            if (!Open_bool)
            {
                mAnimator.SetTrigger("Tr10Open");
                Debug.Log("Door Open");
                Open_bool = true;
            }
            else
            {
                mAnimator.SetTrigger("Tr10Close");
                Open_bool = false;

            }
        }

    }



    public void TestPrint(string _string)
    {
        print(_string);
    }


   /*
   void ButtonOpen() // to be place on open 
    {
        open.gameObject.SetActive(false);
        close.gameObject.SetActive(true);
    }

    void ButtonClose() // to be place on close
    {
        open.gameObject.SetActive(true);
       close.gameObject.SetActive(false);
    }
   */
}
