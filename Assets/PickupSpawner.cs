using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject _pickupPrefab;
    
    [SerializeField]
    private float _minX;
    [SerializeField]
    private float _maxX;
    [SerializeField]
    private float _minZ;
    [SerializeField]
    private float _maxZ;

    private GameObject _spawned;

    // Start is called before the first frame update
    void Start()
    {
        _spawned = Spawn();
    }

    // Update is called once per frame
    void Update()
    {
        if(_spawned == null)
        {
            _spawned = Spawn();
        }
    }


    private GameObject Spawn()
    {
        var xCoord = Random.Range(_minX, _maxX);
        var zCoord = Random.Range(_minZ, _maxZ);
        return GameObject.Instantiate(_pickupPrefab, new Vector3(xCoord, _pickupPrefab.transform.position.y, zCoord), Quaternion.identity);
    }
}
