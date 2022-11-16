using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.GetComponent<DetectTrigger>().CollisionEvent.AddListener(x => PickupHit(x));
        this.gameObject.GetComponent<WallDetection>().WallHitEvent.AddListener(() => WallHit());
    }

    private void WallHit()
    {
        score = score - 1;
        Debug.Log("Score: " + score);
    }

    private void PickupHit(Collider collider)
    {
       if(collider.gameObject.tag == "Pickup")
        {
            score = score + 1;
        }
        Debug.Log("Score: " + score);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
