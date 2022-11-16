using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall : MonoBehaviour
{
    [SerializeField]
    private float _speed = 0.1f;
    [SerializeField]
    private Vector3 _direction = new Vector3(1, 0, 0);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = gameObject.transform.position + _speed * (_direction.normalized);
    }
}
