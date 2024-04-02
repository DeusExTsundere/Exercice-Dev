using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    [SerializeField] private int jumpForce = 1;
    [SerializeField] private KeyCode jumpActivation = KeyCode.None;
    [SerializeField] private GameObject character;
    private bool jumpReset = true;


    void Update()
    {
        if (Input.GetKey(jumpActivation) && jumpReset == true)
        {
            rb.AddForce(transform.up * jumpForce);
            jumpReset = false;
        }

    }

    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        if (collision.gameObject.tag == ("Sol"))
        {
            jumpReset = true;
        }
    }

}
