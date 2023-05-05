using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPickup : MonoBehaviour
{
    public GameObject Pickup;
    public int TimeInterval = 3;
    public float PickupHeight = 0.3f;

    private float _timeElapsed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _timeElapsed += Time.deltaTime;
        if(_timeElapsed > TimeInterval)
        {
            float x = Random.Range(-4.5f, 4.5f);
            float y = PickupHeight;
            float z = Random.Range(-4.5f, 4.5f);
            Instantiate(Pickup, new Vector3(x, y, z), Quaternion.identity);
            _timeElapsed = 0;
        }
    }
}
