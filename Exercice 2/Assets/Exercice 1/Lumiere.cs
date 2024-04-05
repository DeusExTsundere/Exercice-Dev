using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lumiere : MonoBehaviour
{
    public bool active = true;
    [SerializeField] private Color Couleur;
    private Light _light;

    private void Start()
    {
        _light = GetComponent<Light>();
    }
    public void Interrupteur()
    {
        if (active == true)
        {
            _light.intensity = 1;
            active = false;
        }
        else if (active == false)
        {
            _light.intensity = 0;
            active = true;
        }
    }

    private void Update()
    {
        _light.color = Color.Lerp( _light.color, Couleur , Mathf.PingPong(Time.time,1 ));
    }

}
