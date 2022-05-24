using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public Vector3 m;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            m.x = 0.02f;
            m.y = 0f;

            transform.Translate(m);
        }

        if (Input.GetKey(KeyCode.A))
        {
            m.x = -0.02f;
            m.y = 0f;

            transform.Translate(m);
        }
    }
}
