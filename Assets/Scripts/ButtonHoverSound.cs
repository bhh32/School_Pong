using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHoverSound : MonoBehaviour 
{
    [SerializeField] AudioSource audioSource;

    public void PlayHoverSound()
    {
        audioSource.PlayOneShot(audioSource.clip);
    }
}
