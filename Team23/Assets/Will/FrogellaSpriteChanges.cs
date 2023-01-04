using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogellaSpriteChanges : MonoBehaviour
{
    public GameObject player;
    public Sprite FrogellaNoBalloons;
    public Sprite FrogellaOneBalloon;
    public Sprite FrogellaTwoBalloons;
    public Sprite FrogellaThreeBalloons;
    // Update is called once per frame
    void Update()
    {
        if (player.GetComponent<PlayerStats>().balloons == 0)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = FrogellaNoBalloons;
        }
        if (player.GetComponent<PlayerStats>().balloons == 1)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = FrogellaOneBalloon;
        }
         if (player.GetComponent<PlayerStats>().balloons == 2)
        {

        }
         if (player.GetComponent<PlayerStats>().balloons == 3)
        {

        }


    }
}
