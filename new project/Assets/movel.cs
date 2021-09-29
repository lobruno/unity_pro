using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movel : MonoBehaviour
{
    // Start is called before the first frame update
    float a = 1.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (a > 0.5)
        {
            a -= Time.deltaTime;
            transform.Rotate(new Vector3(0, 0, -10) * Time.deltaTime);
        }
        else if (a < 0) { a = 1.0f; }
        else
        {
            transform.Rotate(new Vector3(0, 0, 20) * Time.deltaTime);
        }

    }
}
