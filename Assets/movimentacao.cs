using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimentacao : MonoBehaviour
{
    Vector3 m;
    // Start is called before the first frame update
    void Start()
    {
        m = new Vector3(1, 1, 1);
        transform.position = m;
        m.Set(0, 0, 0);
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.D))
        {
            m.x = 0.01f;
            transform.Translate(m); // o translate é um metodo, por isso é colocado o vetor entre parenteses.
        }

        if (Input.GetKey(KeyCode.A))
        {
            m.x = -0.01f;
            transform.Translate(m);
        }

        if (Input.GetKey(KeyCode.W))
        {

            m.z = 0.01f;
            transform.Translate(m);
        }

        if (Input.GetKey(KeyCode.S))
        {
            m.z = -0.01f;
            transform.Translate(m);
        }

        m.Set(0, 0, 0);
    }
}
