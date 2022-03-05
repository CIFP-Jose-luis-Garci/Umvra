using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Vidas : MonoBehaviour
{
    [SerializeField] Image vidasImage;
    [SerializeField] Sprite[] vidasSprite;
    // Start is called before the first frame update
    void Start()
    {
        int vidas= GameManager.vidasJug;
        vidasImage.sprite = vidasSprite[vidas];
    }


    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemigo")
        {
            GameManager.vidasJug--;
            if (GameManager.vidasJug == 0)
            {
                SceneManager.LoadScene(11);
            }
        }
    }
}
