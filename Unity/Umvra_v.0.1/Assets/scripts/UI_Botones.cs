using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class UI_Botones : MonoBehaviour
{
    public void NuevaPartida()
    {
        GameManager.vidasJug = 3;
        SceneManager.LoadScene(2);
    }

    public void Opciones()
    {
        SceneManager.LoadScene(1);
    }

    public void Menu_Prin()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }

    public void CerrarJuego()
    {
        Application.Quit();
    }

}
