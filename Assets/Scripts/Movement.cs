using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float velocidadeTranslacao;
    public float velocidadeRotacao;
    // Start is called before the first frame update
    void Start()
    {
        velocidadeTranslacao = 120f;
        velocidadeRotacao = 1600f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("d")){
            transform.Rotate(0,velocidadeRotacao * Time.deltaTime,0);
        }
        if (Input.GetKey("a")){
            transform.Rotate(0,-velocidadeRotacao * Time.deltaTime,0);
        }
        if (Input.GetKey("w")){
            transform.Translate(0,0,velocidadeTranslacao * Time.deltaTime);
        }
        if (Input.GetKey("s")){
            transform.Translate(0,0,-velocidadeTranslacao * Time.deltaTime);
        }
    }
}
