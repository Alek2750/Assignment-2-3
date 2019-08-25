using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectPowerUp : MonoBehaviour
{
    

    void OnTriggerEnter(Collider collision)
    {
        
        ScoreCounter.scoreValue += 1;
        Destroy(gameObject);
    }
}
