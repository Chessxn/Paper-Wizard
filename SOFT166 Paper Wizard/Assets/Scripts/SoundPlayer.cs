using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundPlayer : MonoBehaviour
{
    AudioSource sound;
    private void OnEnable()
    {
        sound = GetComponent<AudioSource>();
        sound.Play(0);
    }
}
