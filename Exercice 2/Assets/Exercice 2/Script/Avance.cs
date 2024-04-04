using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class Avance : MonoBehaviour
{
    [SerializeField] private int speed = 10;
    void Update()
    {
        Vector3 _currentPosition = transform.position;
        _currentPosition.x -= speed * Time.deltaTime;
        transform.position = _currentPosition;
    }
}
