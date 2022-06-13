using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puli : MonoBehaviour
{

    private GameObject Puli;
    private CharacterController _cont;
    private float _sensitivity = 1.0f;

    [SerializeField]
    private float _speed = 5.0f;


    bool norestrict= true;
    private float _grav = 1f;

    button0 b;
    button1 b1;
    button2 b2;

    Highlighted h11,h2,h3;

    // Start is called before the first frame update
    void Start()
    {
        _cont = GetComponent<CharacterController>();
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

        b = GameObject.Find("button0").GetComponent<button0>();
        b1 = GameObject.Find("button1").GetComponent<button1>();
        b2 = GameObject.Find("button2").GetComponent<button2>();

        h11= GameObject.Find("High1").GetComponent<Highlighted>();
        h2 = GameObject.Find("high2").GetComponent<Highlighted>();
        h3 = GameObject.Find("high3").GetComponent<Highlighted>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
        if(norestrict==true)
        {
            Movement();
            lookx();
        }
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;
        Physics.Raycast(ray, out hitInfo);
        if (Input.GetMouseButtonDown(0))
        {
            if(hitInfo.transform != null)
            {
                if(hitInfo.transform.tag == "button")
                {

                    h11.entered();
                    Debug.Log("button0 clicked");
                   
                }
                else if (hitInfo.transform.tag == "button1")
                {
                    Debug.Log("button1 clicked");

                    h2.entered1();
                   
                }
                else if (hitInfo.transform.tag == "button2")
                {
                    Debug.Log("button2 clicked");
                    h3.entered2();
                }
            }
        }
    }


    public void swapfun(bool val)
    {
        norestrict= val;
    }

    void Movement()
    {
        float HI = Input.GetAxis("Horizontal");
        float VI = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(HI, 0, VI);
        Vector3 _vel = direction * _speed;
        _vel.y -= _grav;
        _vel = transform.transform.TransformDirection(_vel);
        _cont.Move(_vel * Time.deltaTime);
    }
    void lookx()
    {
        if(Input.GetMouseButton(1))
        {
            float _mouseX = Input.GetAxis("Mouse X");
            Vector3 newRotation = transform.localEulerAngles;
            newRotation.y += _mouseX * _sensitivity;
            transform.localEulerAngles = newRotation;

        }
    }

}
