using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proyectil : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.parent = null;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * 6f * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Robot")
        {
            collision.gameObject.SendMessage("Morir");
        }

        //Destruyo la bala, independientemente de con quién ha chocado
        Destroy(gameObject);
    }
}
