using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TextCore.Text;

public class Impact : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [Header("Réglage des scènes")]
    [SerializeField] private string gameOverMenu;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == ("Obstacle"))
        {
            Destroy(player);
            SceneManager.LoadScene(gameOverMenu,LoadSceneMode.Single);
        }
    }
}
