using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{

    [SerializeField]
    private IntVariable _playerStartHP;
    [SerializeField]
    private IntVariable _playerCurrentHP;

    private void Awake()
    {
        _playerCurrentHP.Value = _playerStartHP.Value;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
