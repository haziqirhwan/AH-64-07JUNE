using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputDataTransfer : MonoBehaviour
{
    public void rcircuitbreaker(bool _rcb)
    {
        GameManager._me.I1 = _rcb;
    }

    public void hydraulicleak(bool _hl)
    {
        GameManager._me.I2 = _hl;
    }

    public void oilleak(bool _ol)
    {
        GameManager._me.I3 = _ol;
    }

    public void refabgun(bool _rgun)
    {
        GameManager._me.I5 = _rgun;
    }

    public void rloaderclutch(bool _lc)
    {
        GameManager._me.I6 = _lc;
    }

    public void apuoilsight(bool _apu)
    {
        GameManager._me.I4 = _apu;
    }

    public void expiredex(bool _expired)
    {
        GameManager._me.I7 = _expired;
    }

    public void missingex(bool _me)
    {
        GameManager._me.I8 = _me;
    }

    public void battery(bool _bat)
    {
        GameManager._me.I9 = _bat;
    }

    public void niu(bool _niu)
    {
        GameManager._me.I10 = _niu;
    }

    public void handpump(bool _hp)
    {
        GameManager._me.I11 = _hp;
    }

    public void hydrauliclowpress(bool _hlp)
    {
        GameManager._me.I12 = _hlp;
    }

    public void servicedip(bool _sd)
    {
        GameManager._me.I13 = _sd;
    }

    public void poppedpin1(bool _pp1)
    {
        GameManager._me.I14 = _pp1;
    }

    public void flatedtire(bool _ft)
    {
        GameManager._me.I16 = _ft;
    }

    public void lefabcb(bool _lcb)
    {
        GameManager._me.I17 = _lcb;
    }

    public void poppedpin2(bool _pp2)
    {
        GameManager._me.I15 = _pp2;
    }

}
