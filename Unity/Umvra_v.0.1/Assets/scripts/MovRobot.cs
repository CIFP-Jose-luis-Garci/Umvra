using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovRobot : MonoBehaviour
{

    Animator animator;
    Rigidbody2D rb;

    float speed;
    [SerializeField] float maxSpeed;
    [SerializeField] float Speed;
    float desplX;

    float jumpForce;

    bool alive = true;

    bool facingRight = true;

    Mov_Camara Camera;

  public GameObject panel_pausa;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();

        Speed = 3.5f;
        jumpForce = 10f;
       // maxSpeed = 5f;


    }

    // Update is called once per frame
    void Update()
    {

        desplX = Input.GetAxis("Horizontal");
        if (alive)
        {
            Girar();

            Saltar();

           
        }

        Pausar();
    }

   // Camera = GetComponent<StopFollowing>();

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Pared")
        {
           // SendMessage
        }
    }






    private void FixedUpdate()
    {
        if (alive)
        {
            Caminar();
            Correr();
          
        }

    }

    void Caminar()
    {
        /*if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            animator.SetBool("Walk", true);
        }
        else if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            animator.SetBool("Walk", false);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            animator.SetBool("Walk", true);
        }
        else if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            animator.SetBool("Walk", false);
        }*/
        if (desplX == 0)
        {
            animator.SetBool("Walk", false);
        }
        else 
        { 
            animator.SetBool("Walk", true); 
        }
        rb.velocity = new Vector2(desplX * Speed, rb.velocity.y);
        speed = rb.velocity.x;
        speed = Mathf.Abs(speed);
       // animator.SetFloat("SpeedX", speed);
        //print(speed);
    }
    void Roll()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            animator.SetBool("Roll", true);
        }
        else if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            animator.SetBool("Roll", false);
        }
        rb.AddForce(Vector2.right * jumpForce, ForceMode2D.Impulse);
        rb.AddForce(Vector2.left * jumpForce, ForceMode2D.Impulse);
            
        
    }
    void Girar()
    {
        if (desplX < 0 && facingRight)
        {
            transform.localScale = new Vector3(-4f, 4f, 4f);
            facingRight = false;
        }
        else if (desplX > 0 && !facingRight)
        {
            transform.localScale = new Vector3(4f, 4f, 4f);
            facingRight = true;
        }
    }

    void Saltar()
    {
        if (Input.GetKeyDown(KeyCode.Space) && animator.GetBool("Grounded"))
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            animator.SetTrigger("Jump");
        }
    }
    void Correr()
    {
       if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            animator.SetBool("Run", true);
        }
        else if (Input.GetKeyUp(KeyCode.LeftControl))
        {
            animator.SetBool("Run", false);
        }
        /*rb.velocity = new Vector2(desplX * maxSpeed, rb.velocity.y);
        speed = rb.velocity.x;
        speed = Mathf.Abs(speed);*/
        speed = 15f;
    }

  void Pausar()
  {
      if (Input.GetKeyDown(KeyCode.Escape))
      {
          Time.timeScale = 0;
      panel_pausa.SetActive(true);
      }
  }

    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
           // print("toco suelo");
            animator.SetBool("Grounded", true);
            animator.SetBool("Fall", false);
        }

    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            print("NO toco suelo");
            animator.SetBool("Grounded", false);
            animator.SetBool("Fall", true);
        }

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
        }

        if (collision.gameObject.tag == "Dormitorio")
        {
            SceneManager.LoadScene("DormitorioL");
        }

    }
}
