using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public GameObject ai;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SelfAround();
        
    }
    void SelfAround()
    {
        transform.RotateAround(ai.transform.position, Vector3.up, speed * Time.deltaTime);
    }
}
