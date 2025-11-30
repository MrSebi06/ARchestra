using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instruments : MonoBehaviour
{
    [SerializeField] private List<Instrument> instruments = new();

    void Start()
    {
        foreach (Instrument instrument in instruments)
        {
            instrument.StartAudio();
        }
    }
}
