using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioEscena : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollision2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Cocina")
        {
            SceneManager.LoadScene("cocina");
        }

        if (collision.gameObject.tag == "EscaleraL")
        {
            SceneManager.LoadScene("EscaleraL");
        }

        if (collision.gameObject.tag == "Lavanderia")
        {
            SceneManager.LoadScene("Lavanderia");
        }

        if (collision.gameObject.tag == "Minipasillo")
        {
            SceneManager.LoadScene("Minipasillo");
        }

        if (collision.gameObject.tag == "OfficeR")
        {
            SceneManager.LoadScene("OfficeR");
        }

        if (collision.gameObject.tag == "OfficeLL")
        {
            SceneManager.LoadScene("OfficeLL");
        }

        if (collision.gameObject.tag == "Pasilloarriba")
        {
            SceneManager.LoadScene("Pasilloarriba");
        }

        if (collision.gameObject.tag == "PasilloMedio")
        {
            SceneManager.LoadScene("PasilloMedio");
        }

        if (collision.gameObject.tag == "Spawn")
        {
            SceneManager.LoadScene("Spawn");
            print("Colision realizada");
        }

        if (collision.gameObject.tag == "Dormitorio")
        {
            SceneManager.LoadScene("DormitorioL");
        }

    }
}
