using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    [Header("Configuration")]
    [SerializeField] private KeyCode jumpActivation = KeyCode.None;
    [SerializeField] private GameObject character;
    [Header("Equilibrage")]
    [SerializeField] private int jumpForce = 1;
    [SerializeField] private float poidsSaut;
    private float poidsOrigine;
    private bool jumpReset = true;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        poidsOrigine = rb.mass;
    }

    void Update()
    {
        if (Input.GetKey(jumpActivation) && jumpReset == true)
        {
            rb.AddForce(transform.up * jumpForce);

            jumpReset = false;
            rb.mass = poidsSaut;
        }

    }

    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        if (collision.gameObject.tag == ("Sol"))
        {
            jumpReset = true;
            rb.mass = poidsOrigine;
        }
    }

}
