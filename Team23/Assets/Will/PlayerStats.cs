using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour

    
{
    public int balloons;
    public int maxBalloons;
    public bool bugsCollected;
    public bool shotBug;

    // Start is called before the first frame update
    void Start()
    {
        
    }

  public void CollectedBalloon()
    {
        balloons = balloons + 1;
    }
    public void frogellaHitTaken()
    {
        balloons = balloons - 1;
    }
    public void CollectedBug()
    {
        bugsCollected = true;
    }
    public void ShotBug()
    {
        bugsCollected = false;
    }

}
