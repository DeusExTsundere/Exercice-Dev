using System;
using UnityEngine;

public class EventHandler : MonoBehaviour
{
    [SerializeField] private ScriptableEvent soundDeathPlay;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == ("Obstacle"))
        {
            soundDeathPlay.PlaySoundAction?.Invoke();
        }
    }

}
