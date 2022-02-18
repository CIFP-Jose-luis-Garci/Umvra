using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_Pausa : MonoBehaviour
{
    public GameObject panel_pausa;
    public GameObject panel_ajustes;

    public void Pausa()
    {
        Time.timeScale = 0;
        panel_pausa.SetActive(true);
    }

    public void Volver()
    {
        Time.timeScale = 1;
        panel_pausa.SetActive(false);
    }

    public void Opciones()
    {
        panel_ajustes.SetActive(true);
    }

    public void Volver_Pausa()
    {
        panel_ajustes.SetActive(false);
    }
}
