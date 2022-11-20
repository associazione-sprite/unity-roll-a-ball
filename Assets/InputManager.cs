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
    [SerializeField]
    private CameraController _cameraController;

    // Start is called before the first frame update
    void Start()
    {
        _movement = gameObject.GetComponent<MoveBall>();
        if(_movement == null)
        {
            Debug.LogError("No Movement attached to this object!");
        }
    }

    private void OnLook(InputValue lookValue)
    {
        var look2d = lookValue.Get<Vector2>();
        this._cameraController.OnLook(look2d);
    }

    private void OnMove(InputValue moveValue)
    {
        
        var move2d = moveValue.Get<Vector2>();
        _movement.Direction = move2d.x * _cameraController.transform.right + move2d.y * _cameraController.transform.forward;
        _movement.Speed = _defaultSpeed;
    }

    // Update is called once per frame
    void Update()
    {
      
    }
}
