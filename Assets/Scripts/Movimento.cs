using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour
{
    private Animator animador;
    public float velocidadePulo;
    public float velocidadeTranslacao;
    public float velocidadeRotacao;
    public bool pulando = false;

    void Start()
    {
        velocidadePulo = 250f;
        velocidadeTranslacao = 5f;
        velocidadeRotacao = 40f;
        animador = GetComponent<Animator>();
    }

    
    void Update()
    {
        if (Input.GetKey("w")){
            transform.Translate(0,0,velocidadeTranslacao * Time.deltaTime);
        }
        if (Input.GetKey("s")){
            transform.Translate(0,0,-velocidadeTranslacao * Time.deltaTime);
        }
        if (Input.GetKey("d")){
            transform.Translate(0,0,velocidadeTranslacao * Time.deltaTime);
            transform.Rotate(0,velocidadeRotacao * Time.deltaTime,0);
        }
        if (Input.GetKey("a")){
            transform.Translate(0,0,velocidadeTranslacao * Time.deltaTime);
            transform.Rotate(0,-velocidadeRotacao * Time.deltaTime,0);
        }
        if (Input.GetKeyDown("space") && !pulando){
            GetComponent<Rigidbody>().AddForce(transform.up * velocidadePulo);
        }
    }

    void OnCollisionEnter(Collision colisao)
    {
        if (colisao.gameObject.CompareTag("Chão")){
            pulando = false;
        }
    }

       void OnCollisionExit(Collision colisao)
    {
        if (colisao.gameObject.CompareTag("Chão")){
            pulando = true;
        }
    }
}
