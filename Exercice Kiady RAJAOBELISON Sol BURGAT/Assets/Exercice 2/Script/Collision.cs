using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TextCore.Text;

public class Collision : MonoBehaviour
{
    [Header("Joueur")]
    [SerializeField] private GameObject player;
    [Header("Réglage objet")]
    [SerializeField] private GameObject failMenu;
    [SerializeField] private GameObject trapAir;
    [SerializeField] private GameObject trapSol;
    [Header("Réglage son")]
    [SerializeField] private AudioSource catSong;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == ("Obstacle"))
        {
            failMenu.SetActive(true);
            Destroy(player);
            Destroy(trapAir);
            Destroy(trapSol);
        }
    }
}
