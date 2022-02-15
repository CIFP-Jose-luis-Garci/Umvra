using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_sliders : MonoBehaviour
{
    float volumen;
    float brillo;
    [SerializeField] Slider mySlider;

    public void SubirVolumen()
    {
        volumen = (mySlider.value);
    }

    public void SubirBrillo()
    {
        brillo = (mySlider.value);
    }
}
