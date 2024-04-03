using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class Impact : MonoBehaviour
{
    [SerializeField] private GameObject character;
    [SerializeField] private int speed = 10;
    public int vitesse { get { return speed; } }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == ("Obstacle"))
        {
            Destroy(character);
            speed = 0;
        }
    }
}
