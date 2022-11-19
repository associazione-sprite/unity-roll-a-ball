using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall : MonoBehaviour
{
    public float Speed { get; set; }
    public Vector3 Direction { get; set; }

    private Rigidbody _rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        Direction = new Vector3(0, 0, 0);
        Speed = 0;
        this.gameObject.GetComponent<WallDetection>().WallHitEvent.AddListener(() => WallHit());
        _rigidbody = gameObject.GetComponent<Rigidbody>();
    }

    private void WallHit()
    {
        this.Direction = this.Direction * -1;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Speed != 0)
        {
            _rigidbody.AddForce(Direction * Speed);
        }
    }
        
}
