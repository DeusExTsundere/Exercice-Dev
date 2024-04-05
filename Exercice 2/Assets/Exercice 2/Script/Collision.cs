using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TextCore.Text;

public class Collision : MonoBehaviour
{
    [SerializeField] private GameObject player;
    public AudioSource catDeath;
    [Header("R�glage des sc�nes")]
    [SerializeField] private string gameOverMenu;

    private void OnEnable()
    {
        catDeath = GetComponent<AudioSource>();
        catDeath.Pause();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == ("Obstacle"))
        {
            catDeath.UnPause();
            Destroy(player);
            SceneManager.LoadScene(gameOverMenu,LoadSceneMode.Single);
        }
    }
}
