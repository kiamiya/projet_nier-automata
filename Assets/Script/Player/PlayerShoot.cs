using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{//moi
    [SerializeField]
    private Transform _cannonTransform;
    [SerializeField]
    private GameObject _bulletPrefab;
    [SerializeField]
    private float _bulletSpeed = 10f;
    [SerializeField]
    private float _delayBetweenShots = 0.5f;

    private float _nextShotTime = 0f;
    private void FireBullet()
    {
        GameObject newBullet = Instantiate(_bulletPrefab, _cannonTransform.position, transform.rotation);
        Bullet bulletComponent = newBullet.GetComponent<Bullet>();
        bulletComponent.Shoot(_bulletSpeed);

        Destroy(newBullet, 5f);

    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) )
        {
            if (Time.time > _nextShotTime)
            {
                FireBullet();
                _nextShotTime = Time.time + _delayBetweenShots;
            }
            
        }
    }
}
