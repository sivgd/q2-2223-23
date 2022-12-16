using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour

    
{
    public int balloons;
    public int maxBalloons;

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
}
