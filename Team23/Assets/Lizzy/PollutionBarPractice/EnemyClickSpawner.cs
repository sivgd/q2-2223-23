using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyClickSpawner : MonoBehaviour
{
    public bool isClicked;
    public GameObject diamond;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    

    public void GenerateDiamond()
    {
        GameObject d = Instantiate(diamond, new Vector3(Random.Range(-12f, 7f), Random.Range(-5f, 5f), 0), Quaternion.identity);
        
        d.transform.localScale = new Vector3(Random.Range(0.1f, 1f), Random.Range(0.1f, 1f), 1);
        d.transform.rotation = new Quaternion(Random.Range(0f, 90f), Random.Range(0f, 90f), 0, 0);

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
