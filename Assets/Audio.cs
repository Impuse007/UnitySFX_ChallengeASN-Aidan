using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    public AudioSource AudioPlayer;

    private void OnTriggerEnter()
    {
        AudioPlayer.Play();
    }
}
