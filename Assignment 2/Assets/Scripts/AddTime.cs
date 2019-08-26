using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddTime : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "PickUpTime")
        {
            //add time
            CountdownTimer.currentTime += 10;
            Destroy(other.gameObject);
        }
    }
}
