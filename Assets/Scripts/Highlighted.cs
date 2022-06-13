using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Highlighted : MonoBehaviour
{
    public puli pl;
    private bool _ooo= false;

    button0 b0;
    button1 b1;
    button2 b2;
    void Start()
    {
        pl = GetComponent<puli>();
        b0 = GameObject.Find("button0").GetComponent<button0>();
        b1 = GameObject.Find("button1").GetComponent<button1>();
        b2 = GameObject.Find("button2").GetComponent<button2>();
    }
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.E))
        {
            transform.position = transform.position + new Vector3(0, 0, -4);
        }

        if (transform.position.x > -22 && transform.position.x <= -15 && transform.position.z >= -3 && transform.position.z <= 2)
        {
            pl.swapfun(false);
            Debug.Log("You are on region");
            entered();
        }


        else if (transform.position.x >= -4.63f && transform.position.x <= 3.19 && transform.position.z >= -1.87 && transform.position.z <= 1.59)
        {
         pl.swapfun(false);

           Debug.Log("You are on region 2");
            entered1();

        }

        else if(transform.position.x>=17.7 && transform.position.x<=26.6 && transform.position.z>=-2.78 && transform.position.z<=1.09)
        {
            pl.swapfun(false);
            entered2();
        }

        else
        {
            pl.swapfun(true);
        }
    }

   public void entered()
    {
        if (Input.GetMouseButton(0))
        {

            b0.makemove();
        }
    }

    public void entered1()
    {
        if (Input.GetMouseButton(0))
        {

            b1.makemove();
        }
    }
    public void entered2()
    {
        if (Input.GetMouseButton(0))
        {

            b2.makemove();
        }
    }

}

