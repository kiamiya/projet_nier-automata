using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCollisions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
   /* private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }*/
    public void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
