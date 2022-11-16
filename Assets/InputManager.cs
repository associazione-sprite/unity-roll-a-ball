using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class InputManager : MonoBehaviour
{
    private MoveBall _movement;
    private bool move = false;
    // Start is called before the first frame update
    void Start()
    {
        _movement = gameObject.GetComponent<MoveBall>();
        if(_movement == null)
        {
            Debug.LogError("No Movement attached to this object!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            move = !move;
            if (move)
            {
                var random = new Random();
                _movement.Direction = new Vector3(random.Next(-1,2), 0, random.Next(-1, 2));
                _movement.Speed = 0.5f;
            }
            else
            {
                _movement.Speed = 0;
            }
        }
    }
}
