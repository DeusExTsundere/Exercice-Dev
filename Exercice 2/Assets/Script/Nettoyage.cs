using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nettoyage : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }
}
