using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleChange : MonoBehaviour
{
    public Vector2 scaleChange;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = scaleChange;
    }
}
