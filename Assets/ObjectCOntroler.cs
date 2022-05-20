using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCOntroler : MonoBehaviour
{

    public float xSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < 9)
        {
            transform.position += new Vector3(xSpeed,0,0);
        }

    }
}
