using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Random = System.Random;

public class InputManager : MonoBehaviour
{
    private MoveBall _movement;
    [SerializeField]
    private float _defaultSpeed = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        _movement = gameObject.GetComponent<MoveBall>();
        if(_movement == null)
        {
            Debug.LogError("No Movement attached to this object!");
        }
    }


    private void OnMove(InputValue moveValue)
    {
        var move2d = moveValue.Get<Vector2>();
        _movement.Direction = new Vector3(move2d.x, 0, move2d.y);
        _movement.Speed = _defaultSpeed;
    }

    // Update is called once per frame
    void Update()
    {
      
    }
}
