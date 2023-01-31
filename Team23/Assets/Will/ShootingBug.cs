using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingBug : MonoBehaviour
{
    private Camera mainCam;
    private Vector3 mousePos;
    public GameObject bullet;
    public float fireSpeed = 1000;
    public GameObject FireFrom;
    private Rigidbody2D rb2;
    // Start is called before the first frame update
    void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();
        mainCam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
    }
    // Update is called once per frame
    void Update()
    {
        mousePos = mainCam.ScreenToWorldPoint(Input.mousePosition);

        Vector3 rotation = mousePos - transform.position;

        float rotZ = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0, 0, rotZ);

        //if (GetComponent<PlayerStats>().bugsCollected == true)
        //{
            if (Input.GetButtonDown("Fire1"))
            {
                GameObject b = Instantiate(bullet, FireFrom.transform.position, Quaternion.identity);
                Rigidbody2D rb2b = b.GetComponent<Rigidbody2D>();
                rb2b.AddForce(fireSpeed * transform.up);
                Destroy(b , 2.0f);
            }
        //}
    }
}
