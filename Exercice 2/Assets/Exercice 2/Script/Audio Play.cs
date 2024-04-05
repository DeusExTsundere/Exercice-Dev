using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audioplay : MonoBehaviour
{
    [Header("Réglage Audio")]
    [SerializeField] private AudioSource catDeath;
    void Start()
    {
        catDeath.Play();
    }
}
