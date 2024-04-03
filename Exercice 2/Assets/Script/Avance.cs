using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class Avance : MonoBehaviour
{
    [SerializeField] private GameObject player;
    private Impact speed;
    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        player = gameObject.GetComponent<player>();
        rb.transform.forward = transform.forward;
    }
}
