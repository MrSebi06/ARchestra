using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class Instrument : MonoBehaviour
{
    [SerializeField] private GameObject model;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private Instrument other;

    public void StartAudio()
    {
        audioSource.Play();
    }

    public void OnPlay(bool disableOther = true)
    {
        Debug.Log($"{gameObject.name} - OnPlay called");
        model.SetActive(true);
        audioSource.mute = false;

        if (!disableOther) return;
        other.OnStop();
    }

    public void OnStop()
    {
        Debug.Log($"{gameObject.name} - OnStop called");
        model.SetActive(false);
        audioSource.mute = true;
    }
}
