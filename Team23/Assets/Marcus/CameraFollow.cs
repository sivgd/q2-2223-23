using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    //public Transform target;
    public GameObject player;
    private Vector3 offset;
    public bool border;
    public float minX;
    public float maxX;

    public float minY;
    public float maxY;
    //[Range(0,10)]
    //public float smoothFactor;



    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position;

        //Work in progress camera delay
        //Follow();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + offset;

        if(border==true)
        {
            transform.position = new Vector3(Mathf.Clamp(transform.position.x, minX, maxX), Mathf.Clamp(transform.position.y, minY, maxY), transform.position.z);
        }

        //Work in progress camera delay
        //Vector3 targetPosition = target.position + offset;
        //Vector3 smoothPosition = Vector3.Lerp(transform.position, targetPosition, smoothFactor*Time.fixedDeltaTime);
        //transform.position = smoothPosition;
    }
}
