using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
    [SerializeField]
    private IntVariable _playerCurrentHP;
    [SerializeField]
    private IntVariable _enemyCount;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            _playerCurrentHP.Value = _playerCurrentHP.Value - 1;
     // ou : _playerCurrentHP.Value --;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        _enemyCount.Value--;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
