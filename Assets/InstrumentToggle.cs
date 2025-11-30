using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstrumentToggle : MonoBehaviour
{
    [SerializeField] private InstrumentUI instrumentUI;
    [SerializeField] [Range(1, 2)] private int id;

    public void OnToggle(bool on)
    {
        Debug.Log(id);
        Instrument instrument = id == 1 ? instrumentUI.instrument1 : instrumentUI.instrument2;
        if (on)
        {
            instrument.OnPlay(disableOther: false);
        }
        else
        {
            instrument.OnStop();
        }
    }
}
