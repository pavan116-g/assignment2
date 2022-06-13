using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button0 : MonoBehaviour
{
    private float _speed = 25f;
    private puli pl;
    private GameObject highlight;
    [SerializeField]
    private GameObject Sphere;
    private bool bd = false;

    float speed = 1f;
    float delta = 3f;
    private Rigidbody _rgd;
    // Start is called before the first frame update
    void Start()
    {
        pl = GetComponent<puli>();

    }
    public int interpolationFramesCount = 45; // Number of frames to completely interpolate between the 2 positions
    int elapsedFrames = 0;
    
    // Update is called once per frame
    void Update()
    {


    }


    public void makemove()
    {
     

        GameObject ob = Instantiate(Sphere, transform.position + new Vector3(0, 0, 1), Quaternion.identity);
        _rgd = ob.GetComponent<Rigidbody>();
        _rgd.AddForce(Vector3.forward * 3000);
       

    }

    public void movementbutton()
    {
        float t=0;
        float a = transform.position.y;
        float b = transform.position.y - 3;
        float valueToLerp = Mathf.Lerp(a,b,t);
        t += 0.5f * Time.deltaTime;
       
    } 
   
}