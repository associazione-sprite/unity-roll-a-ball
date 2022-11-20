using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;

    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + (transform.rotation * offset);
    }

    internal void OnLook(Vector2 look2d)
    {
        transform.RotateAround(player.transform.position, Vector3.up, look2d.x * 0.05f);
    }
}
