using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall : MonoBehaviour
{
    public float Speed { get; set; }
    public Vector3 Direction { get; set; }

    // Start is called before the first frame update
    void Start()
    {
        Direction = new Vector3(0, 0, 0);
        Speed = 0;
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = gameObject.transform.position + Speed * (Direction.normalized)*Time.deltaTime;
    }
}
