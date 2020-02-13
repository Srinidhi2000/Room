using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fan_rotation : MonoBehaviour
{
    float spinSpeed = 50.0f;
    bool isTap = false;
    // Start is called before the first frame update
     void OnMouseDown()
    {
        isTap = !isTap;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {if (isTap)
        { transform.Rotate(0, spinSpeed * Time.deltaTime, 0); }
       // else { transform.Rotate(0, 0, 0); }

    }
}
