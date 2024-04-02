using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class Collision : MonoBehaviour
{
    [SerializeField] private GameObject character;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == ("Obstacle"))
        {
            Destroy(character);
        }
    }
}
