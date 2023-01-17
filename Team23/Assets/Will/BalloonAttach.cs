using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonAttach : MonoBehaviour
{
    public GameObject player;
    public GameObject balloon1;
    public GameObject balloon2;
    public GameObject balloon3;
    public float scaler;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (player.GetComponent<PlayerStats>().balloons <= 0)
        {
            balloon1.transform.parent = player.transform;
            balloon1.transform.localPosition = new Vector3(0, 999, 0);
            balloon2.transform.localPosition = new Vector3(0, 999, 0);
            balloon3.transform.localPosition = new Vector3(0, 999, 0);
        }

        if (player.GetComponent<PlayerStats>().balloons == 1)
        {
            balloon1.transform.parent = player.transform;
            balloon1.transform.localPosition = new Vector3(0, .13f, 0.01f);
            balloon2.transform.localPosition = new Vector3(0, 999, 0);
            balloon3.transform.localPosition = new Vector3(0, 999, 0);
        }

        if (player.GetComponent<PlayerStats>().balloons == 2)
        {
            balloon2.transform.parent = player.transform;
            balloon1.transform.localPosition = new Vector3(0, 999, 0);
            balloon2.transform.localPosition = new Vector3(0, .13f, 0.01f);
            balloon3.transform.localPosition = new Vector3(0, 999, 0);
        }

        if (player.GetComponent<PlayerStats>().balloons == 3)
        {
            balloon3.transform.parent = player.transform;
            balloon1.transform.localPosition = new Vector3(0, 999, 0);
            balloon2.transform.localPosition = new Vector3(0, 999, 0);
            balloon3.transform.localPosition = new Vector3(0, .13f, 0.01f);
        }
    }
}
