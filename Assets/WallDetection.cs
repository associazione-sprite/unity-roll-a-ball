using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class WallDetection : MonoBehaviour
{
    private MoveBall _movement;
    public UnityEvent WallHitEvent = new UnityEvent();

    // Start is called before the first frame update
    void Start()
    {
        _movement = gameObject.GetComponent<MoveBall>();
        if (_movement == null)
        {
            Debug.LogError("No Movement attached to this object!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Wall")
        {
            WallHitEvent.Invoke();
        }
    }
}
