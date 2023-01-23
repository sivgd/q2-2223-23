using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForPoints : MonoBehaviour
{
    public GameObject obj1;
    public GameObject obj2;
    public LineRenderer lr;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(obj1.transform.position, obj2.transform.position);
        Debug.Log(distance);

        lr.SetPosition(0, obj1.transform.position);
        lr.SetPosition(1, obj2.transform.position);

    }
}
