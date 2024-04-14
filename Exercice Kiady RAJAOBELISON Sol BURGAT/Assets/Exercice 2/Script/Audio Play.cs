using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audioplay : MonoBehaviour
{
    [Header("Réglage Audio")]
    [SerializeField] private AudioSource catDeath;
    [SerializeField] private ScriptableEvent playSoundDeath;

    private void OnEnable()
    {
        playSoundDeath.PlaySoundAction += PlaySound;
    }

    private void PlaySound()
    {
        catDeath.Play();
    }

    private void OnDisable()
    {
        playSoundDeath.PlaySoundAction -= PlaySound;
    }
}
