using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampa : MonoBehaviour
{
    GameObject[] torretas;
    private void Start()
    {

        torretas = GameObject.FindGameObjectsWithTag("Enemigo");
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "RobotBoyIdleSprite_0")
        {
            //Activar torretas
            foreach (GameObject torreta in torretas)
            {
                torreta.SendMessage("Activar");
            }
        }

    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.name == "RobotBoyIdleSprite_0")
        {
            foreach (GameObject torreta in torretas)
            {
                torreta.SendMessage("Desactivar");
            }
        }

    }
}
