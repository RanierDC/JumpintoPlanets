using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public Vector2 rotateChange ; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
          transform.Rotate(rotateChange);
    }
}
