using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour

{
    private Rigidbody _rigidbody;
    private float _speed;
    
    void Awake() 
    {
     _rigidbody = GetComponent<Rigidbody>();
    }

    public void Shoot(float speed)
    {
        _speed = speed;
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        _rigidbody.MovePosition(transform.position + transform.forward * _speed * Time.fixedDeltaTime);
    }
}
