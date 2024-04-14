using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laser : MonoBehaviour
{
    [SerializeField] private int speed = 6;
    void Update()
    {
        Vector3 _currentPosition = transform.position;
        _currentPosition.y += speed * Time.deltaTime;
        transform.position = _currentPosition;
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

}
