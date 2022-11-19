using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RodaRodando : MonoBehaviour
{
    // Start é chamado antes da primeira atualização de frame, quando o objeto é criado
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w") || Input.GetKey("a") || Input.GetKey("d")){
            transform.Rotate(2000f * Time.deltaTime,0,0);
        }
        if (Input.GetKey("s")){
            transform.Rotate(-2000f * Time.deltaTime,0,0);
        }
    }
}
