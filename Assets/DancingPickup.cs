using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DancingPickup : MonoBehaviour
{
    [SerializeField]
    private Vector3 rotation = new Vector3(30, 30, 30);
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotation * Time.deltaTime);
    }
}

