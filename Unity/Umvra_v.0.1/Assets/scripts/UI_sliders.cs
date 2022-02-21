using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_sliders : MonoBehaviour
{
    public Slider sliderBrillo;
    public float sliderValueBrillo;
    public Image panelBrillo;

    void Start()
    {
        sliderBrillo.value = PlayerPrefs.GetFloat("brillo", 0.5f);

        panelBrillo.color = new Color(panelBrillo.color.r, panelBrillo.color.g, panelBrillo.color.b, sliderBrillo.value);
    }

    public void CambiarSlider(float valor)
    {
        sliderValueBrillo = valor;
        PlayerPrefs.SetFloat("brillo", sliderValueBrillo);
        panelBrillo.color = new Color(panelBrillo.color.r, panelBrillo.color.g, panelBrillo.color.b, sliderBrillo.value);
    }
}
