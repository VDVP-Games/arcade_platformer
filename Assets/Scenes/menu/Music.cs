using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Menu : MonoBehaviour
{
    public AudioMixer audioMixer;

    public void SetVolue(float volume)
    {
        audioMixer.SetFloat("volume_1", Mathf.Log10(volume) * 20);
    }

    public void Sound()
    {
        AudioListener.pause = !AudioListener.pause;
    }
}
