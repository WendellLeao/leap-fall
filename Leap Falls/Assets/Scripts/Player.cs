using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float velocidadeMaxima;

    public float forcaPulo;

    public bool BoostUp = false;
    public bool BoostLeft = false;

    public bool isPaused = false;
    public bool noChao = false;
    public bool Comecou = false;

    public GameObject Respawn;

    public GameObject PainelPlay;
    public GameObject PainelPause;

    public GameObject Plataform;
    public GameObject Botao;

    public GameObject Plataform2;
    public GameObject Botao2;

    public GameObject Espinhos;

    public GameObject Boost_up_transparence;
    public GameObject Boost_left_transparence;

    //Smash da fase lvl 11 (com botão)
    public GameObject Smash1;
    public GameObject Smash2;

    void Start()
    {

    }

    void Update()
    {
    

        Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();

        float movimento = Input.GetAxis("Horizontal");

        rigidbody.velocity = new Vector2(movimento * velocidadeMaxima, rigidbody.velocity.y);

        if (Comecou == false && Input.GetKeyDown(KeyCode.Space))
        {
            Comecou = true;
            velocidadeMaxima = 4;
            noChao = false;
        }

        if (Comecou == true)
        {
            rigidbody.gravityScale = -1;
            PainelPlay.SetActive(false);
        }

        if (Comecou == false)
        {
            rigidbody.gravityScale = 0;
            velocidadeMaxima = 0;
            PainelPlay.SetActive(true);
            transform.position = Respawn.transform.position;
        }

        //Pular
        if (noChao && Comecou)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                GetComponent<Rigidbody2D>().AddForce(new Vector2(rigidbody.velocity.x, forcaPulo));
            }
        }

        if (BoostUp)
        {
            rigidbody.gravityScale = -5;
        }
    }



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Chao"))
        {
            noChao = true;
        }

        if (collision.gameObject.CompareTag("Spy"))
        {
            Comecou = false;

            Botao.SetActive(true);
            Plataform.SetActive(true);

            Plataform2.SetActive(true);
            Botao2.SetActive(true);
        }

        if (collision.gameObject.CompareTag("SmashSpy"))
        {
            Comecou = false;
            Botao.SetActive(true);
            Plataform.SetActive(true);
            Espinhos.SetActive(true);
            Plataform2.SetActive(true);
            Botao2.SetActive(true);
        }

        if (collision.gameObject.CompareTag("SmashSpy_lvl_11"))
        {
            Comecou = false;

            Botao.SetActive(true);
            Plataform.SetActive(true);

            Plataform2.SetActive(true);
            Botao2.SetActive(true);
        }

        if (collision.gameObject.CompareTag("Botão"))
        {
            Plataform.SetActive(false);
            Botao.SetActive(false);
            noChao = false;
        }

        if (collision.gameObject.CompareTag("Botão2"))
        {
            Plataform2.SetActive(false);
            Botao2.SetActive(false);

            noChao = false;
        }

        if (collision.gameObject.CompareTag("Botão2_lvl_11"))
        {
            Espinhos.SetActive(false);
            Plataform2.SetActive(false);
            Botao2.SetActive(false);

            noChao = false;
        }

        if (collision.gameObject.CompareTag("Botão2_lvl12"))
        {
            Espinhos.SetActive(false);
            Plataform2.SetActive(false);
            Botao2.SetActive(false);

            noChao = false;
        }

        if (collision.gameObject.CompareTag("Botao_lvl10"))
        {
            Plataform.SetActive(false);
            Botao.SetActive(false);

            noChao = false;
        }

        if (collision.gameObject.CompareTag("Botão2_lvl_13"))
        {
            Plataform.SetActive(false);
            Botao.SetActive(false);
            Botao2.SetActive(false);

            noChao = false;
        }

        if (collision.gameObject.CompareTag("Botão_lvl_13"))
        {
            Plataform.SetActive(false);
            Botao.SetActive(false);

            noChao = false;
        }

        if (collision.gameObject.CompareTag("BotaoSmash"))
        {
            //Apertou = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Chao"))
        {
            noChao = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Finish"))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Lvl_2");
        }

        if (collision.gameObject.CompareTag("Finish_2"))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Lvl_3");
        }

        if (collision.gameObject.CompareTag("Finish_3"))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Lvl_4");
        }

        if (collision.gameObject.CompareTag("Finish_4"))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Lvl_5");
        }

        if (collision.gameObject.CompareTag("Finish_5"))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Lvl_6");
        }

        if (collision.gameObject.CompareTag("Finish_6"))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Lvl_7");
        }
        if (collision.gameObject.CompareTag("Finish_7"))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Lvl_8");
        }
        if (collision.gameObject.CompareTag("Finish_8"))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Lvl_9");
        }
        if (collision.gameObject.CompareTag("Finish_9"))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Lvl_10");
        }
        if (collision.gameObject.CompareTag("Finish_10"))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Lvl_11");
        }

        if (collision.gameObject.CompareTag("Finish_11"))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Lvl_12");
        }
        if (collision.gameObject.CompareTag("Finish_12"))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Lvl_13");
        }


        if (collision.gameObject.CompareTag("Boost_up"))
        {
            Boost_up_transparence.SetActive(true);
            BoostUp = true;
        }

        if (collision.gameObject.CompareTag("Boost_left"))
        {
            Boost_left_transparence.SetActive(true);
            BoostLeft = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Boost_up"))
        {
            Boost_up_transparence.SetActive(false);
            BoostUp = false;
        }
    }

    public void Pause()
    {
        PainelPause.SetActive(true);
        isPaused = true;     
    }
}
