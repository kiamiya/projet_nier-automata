using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWalker : MonoBehaviour
{
    public Transform _playerTransform;

    [SerializeField]
    private float _speed = 5f;
    [SerializeField]
    private float _rotateSpeed = 5f;
    
    private Rigidbody _rigidbody;
   
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }
    void Update()
    {
        /*Vector3 relPos = _playerTransform.position - transform.position;
        Quaternion relQ = Quaternion.LookRotation(relPos);
        transform.rotation = Quaternion.RotateTowards( transform.rotation, relQ, _rotateSpeed );*/
    }
    void FixedUpdate()
    {
        Vector3 relPos = _playerTransform.position - transform.position;
        Quaternion relQ = Quaternion.LookRotation(relPos);
        _rigidbody.MoveRotation(Quaternion.RotateTowards(transform.rotation, relQ, _rotateSpeed));

        _rigidbody.velocity = transform.forward * _speed;
    }

   
}

