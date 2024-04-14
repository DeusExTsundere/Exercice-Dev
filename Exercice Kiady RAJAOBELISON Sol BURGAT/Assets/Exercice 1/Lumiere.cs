using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lumiere : MonoBehaviour
{
    public bool active = true;
    private Color Couleur;
    [Header("Si coché controle par inspector")]
    [SerializeField] private bool _choixControle = true;
    [Header("Réglage light")]
    [SerializeField, Range(0,1)] public float Red;
    [SerializeField, Range(0,1)] public float Green;
    [SerializeField, Range(0,1)] public float Blue;
    [SerializeField,Range(0,2)] public float Intensite;
    [Header("Paramètre")]
    [SerializeField] public Toggle switchOnOff;
    [SerializeField] public Slider redSlider;
    [SerializeField] public Slider greenSlider;
    [SerializeField] public Slider blueSlider;
    [SerializeField] public Slider sliderIntensite;
    [SerializeField]private GameObject _light;
    private Light lumiere;

    private void Start()
    {
        lumiere = _light.GetComponent<Light>();
        Interrupteur();
    }
    public void Interrupteur()
    {
        if (active == true)
        {
            _light.SetActive(active);
            active = false;
        }
        else if (active == false)
        {
            _light.SetActive(active);
            active = true;
        }
    }

    private void Update()
    {
        if (_choixControle == true) 
        {
            Couleur = new Color(Red, Green, Blue);
            lumiere.intensity = Intensite;
        }
        else
        {
            Couleur = new Color(redSlider.value, blueSlider.value, greenSlider.value);
            lumiere.intensity = sliderIntensite.value;
        }
        lumiere.color = Color.Lerp(lumiere.color, Couleur, Mathf.PingPong(Time.time, 1));

    }

}
