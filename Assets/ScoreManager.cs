using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI textField;
    private int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.GetComponent<DetectTrigger>().CollisionEvent.AddListener(x => PickupHit(x));
        this.gameObject.GetComponent<WallDetection>().WallHitEvent.AddListener(() => WallHit());
        ShowScore();
    }

    private void ShowScore()
    {
        textField.text = $"Score: {score}";
    }

    private void WallHit()
    {
        score = score - 1;
        ShowScore();
    }

    private void PickupHit(Collider collider)
    {
        if (collider.gameObject.tag == "Pickup")
        {
            score = score + 1;
        }
        ShowScore();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
