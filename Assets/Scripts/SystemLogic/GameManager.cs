using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager _me;
    public bool IsTutorialMode = false;
    public bool TutorialVoiceTrigger = false;
    public bool IsAssessmentMode = false;
    public bool F1, F2, F3, F4, F5, F6, F7, F8, F9, F10, F11, F12, F13, F14, F15, F16, F17; // Fault Settings to be called via Bool
    public bool InsideTrigger = false;
    public bool I1, I2, I3, I4, I5, I6, I7, I8, I9, I10, I11, I12, I13, I14, I15, I16, I17;

    private void Awake()
    {
        if (_me)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _me = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }



    //RightEFAB
    public void RCircuitBreaker(bool _RCB)
    {
        F1 = _RCB;
    }

    public void HydrualicLeak(bool _HL)
    {
        F2 = _HL;
    }

    public void OilLeak(bool _OL)
    {
        F3 = _OL;
    }

    //Extinguisher
    public void ApuOilSight(bool _APU)
    {
        F4 = _APU;

    }
    public void REFABGun(bool _RGun)
    {
        F5 = _RGun;
    }


    //Avionics Bay
    public void RLoaderClutch(bool _LC)
    {
        F6 = _LC;
    }

    //Aft Avionics bay
    public void ExpiredEx(bool _Expired)
    {
        F7 = _Expired;
    }

    //Accumulator
    public void MissingEx(bool _ME)
    {
        F8 = _ME;
    }

    public void Battery(bool _BAT)
    {
        F9 = _BAT;
    }

    public void NIU(bool _Niu)
    {
        F10 = _Niu;
    }

    //Catwalk
    public void HandPump(bool _HP)
    {
        F11 = _HP;
    }

    public void HydraulicLowPress(bool _HLP)
    {
        F12 = _HLP;
    }

    //Engine
    public void ServiceDip(bool _SD)
    {
        F13 = _SD;
    }

    //Left EFAB
    public void PoppedPin1(bool _PP)
    {
        F14 = _PP;

    }
    public void Flatedtire(bool _FT)
    {
        F16 = _FT;
    }

    public void Lefabcb(bool _LCB)
    {
        F17 = _LCB;
    }

    public void PoppedPin2(bool _PP2)
    {
        F15 = _PP2;

    }


    //SIMULATOR CANVASES
    //RightEFAB
    public void rcircuitbreaker(bool _rcb)
    {
        I1 = _rcb;
    }

    public void hydraulicleak(bool _hl)
    {
        I2 = _hl;
    }

    public void oilleak(bool _ol)
    {
        I3 = _ol;
    }

    //Extinguisher


    public void apuoilsight(bool _apu)
    {
        I4 = _apu;
    }
    public void refabgun(bool _rgun)
    {
        I5 = _rgun;
    }
    //Avionics Bay
    public void rloaderclutch(bool _lc)
    {
        I6 = _lc;
    }

    //Aft Avionics bay
    public void epiredex(bool _expired)
    {
        I7 = _expired;
    }

    //Accumulator
    public void missingex(bool _me)
    {
        I8 = _me;
    }

    public void battery(bool _bat)
    {
        I9 = _bat;
    }

    public void niu(bool _niu)
    {
        I10 = _niu;
    }

    //Catwalk
    public void handpump(bool _hp)
    {
        I11 = _hp;
    }

    public void hydrauliclowpress(bool _hlp)
    {
        I12 = _hlp;
    }

    //Engine
    public void servicedip(bool _sd)
    {
        I13 = _sd;
    }

    //Left EFAB
    public void poppedpin1(bool _pp1)
    {
        I14 = _pp1;

    }
    public void flatedtire(bool _ft)
    {
        I16 = _ft;
    }

    public void lefabcb(bool _lcb)
    {
        I17 = _lcb;
    }

    public void poppedpin2(bool _pp2)
    {
        I15 = _pp2;

    }
}


