using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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

    // Update is called once per frame
    void Update()
    {
        _movement.Direction = Vector3.zero;
        _movement.Speed = 0;

        if (Input.GetKey(KeyCode.W))
        {
            _movement.Direction = Vector3.forward;
            _movement.Speed = _defaultSpeed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            _movement.Direction = Vector3.left;
            _movement.Speed = _defaultSpeed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            _movement.Direction = Vector3.back;
            _movement.Speed = _defaultSpeed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            _movement.Direction = Vector3.right;
            _movement.Speed = _defaultSpeed;
        }

    }
}
