using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button2 : MonoBehaviour
{
    private float _speed = 25f;
    private puli pl;
    private GameObject highlight;
    [SerializeField]
    private GameObject Sphere2;
    private bool bd = false;


    private Rigidbody _rgd;
    // Start is called before the first frame update
    void Start()
    {
        pl = GetComponent<puli>();

    }

    // Update is called once per frame
    void Update()
    {
       

    }


   public void makemove()
    {


        GameObject ob = Instantiate(Sphere2, transform.position + new Vector3(0, 0, 1), Quaternion.identity);
        _rgd = ob.GetComponent<Rigidbody>();
        _rgd.AddForce(Vector3.forward * 1000);

    }

    IEnumerator buttonmovement()
    {

        Debug.Log("Hi");
        transform.Translate(Vector3.down * Time.deltaTime * _speed);
        yield return new WaitForSeconds(1.2f);
        transform.Translate(new Vector3(0, 3.73f, 0) * Time.deltaTime * _speed);
        bd = false;

    }
}
