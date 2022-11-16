using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupLogic : MonoBehaviour
{
    [SerializeField]
    private string _isDestroyedBy = "Ball";

    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.GetComponentInChildren<DetectTrigger>()
            .CollisionEvent
            .AddListener(x => CollisionStarted(x));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CollisionStarted(Collider other)
    {
        if(other.gameObject.tag == _isDestroyedBy)
        {
            Destroy(gameObject);
        }
    }

}

