using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    Animator animator;

    //Referencia para instanciar
    [SerializeField] Transform InstanciaBalas;
    //Bala
    [SerializeField] GameObject Proyectil
       ;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void Activar()
    {
        animator.SetBool("Disparando", true);
    }

    public void Desactivar()
    {
        animator.SetBool("Disparando", false);
    }

    void Disparar()
    {
        print("FUEGO");
        //Instanciamos la bala en el canon
        Instantiate(Proyectil, InstanciaBalas);
    }

}
