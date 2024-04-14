using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField]private int speedRotation = 5;
    private Vector3 offset;


    void Update()
    {
        offset.z += speedRotation * Time.deltaTime;
        transform.rotation = Quaternion.Euler(offset.x,offset.y,offset.z);
    }
}
