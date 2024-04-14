using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pointdevie : MonoBehaviour
{
    [SerializeField] private int pointDeVie = 4;
    [SerializeField] private GameObject failMenu;
    [SerializeField] private GameObject HUD;

    public int vie { get { return pointDeVie; } }

    private void OnTriggerEnter(Collider other)
    {
        pointDeVie -= 1;
        Destroy(other.gameObject);
        if (pointDeVie <= 0)
        {
            HUD.SetActive(false);
            failMenu.SetActive(true);
            Destroy(gameObject);
        }
    }
}
