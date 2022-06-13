using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookY : MonoBehaviour
{

    private float _sensitivity = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            float _mouseY = Input.GetAxis("Mouse Y");
            Vector3 newRotation = transform.localEulerAngles;
            newRotation.x -= _mouseY * _sensitivity;
            transform.localEulerAngles = newRotation;



        }
    }
}
