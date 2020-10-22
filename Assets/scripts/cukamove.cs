using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cukamove : MonoBehaviour
{
    public Rigidbody cube;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            cube.AddForce(5, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            cube.AddForce(0, 0, 5);
        }
        if (Input.GetKey("space"))
        {
            cube.AddForce(0, 3, 0);
        }
    }
}
