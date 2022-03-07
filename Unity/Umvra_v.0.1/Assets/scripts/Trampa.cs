using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampa : MonoBehaviour
{

    Rigidbody2D rb;

    GameObject[] torretas;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        torretas = GameObject.FindGameObjectsWithTag("Enemigo");
    }
    

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "jugador")
        {
            print("OWO");
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
