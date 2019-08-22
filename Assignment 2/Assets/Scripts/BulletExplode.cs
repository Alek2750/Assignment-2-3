using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletExplode : MonoBehaviour
{

    public float dieTime = 5f;
    public GameObject collisionExplosion;

    // Start is called before the first frame update
    /*void Start()
    {
        Destroy(gameObject, dieTime);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "AIThirdPersonController")
        {
            GameObject explosion = (GameObject)Instantiate(
                collisionExplosion, transform.position, transform.rotation);
            Destroy(gameObject);
            Destory(explosion, 5f);
            return;
        }

    }

    */
}
