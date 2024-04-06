using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lumiere : MonoBehaviour
{
    public bool active = true;
    private Color Couleur;
    [SerializeField, Range(0,1)] public float Red;
    [SerializeField, Range(0,1)] public float Green;
    [SerializeField, Range(0,1)] public float Blue;
    [SerializeField]private GameObject _light;
    private Light lumiere;

    private void Start()
    {
        lumiere = _light.GetComponent<Light>();
    }
    public void Interrupteur()
    {
        if (active == true)
        {
            lumiere.intensity = 1;
            active = false;
        }
        else if (active == false)
        {
            lumiere.intensity = 0;
            active = true;
        }
    }

    private void Update()
    {
        Couleur = new Color(Red, Green, Blue);
        lumiere.color = Color.Lerp( lumiere.color, Couleur , Mathf.PingPong(Time.time,1 ));
    }

}
