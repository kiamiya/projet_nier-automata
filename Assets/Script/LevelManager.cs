using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    [SerializeField]
    private IntVariable _currentPlayerHP;
    [SerializeField]
    private IntVariable _enemyCount;

    // Start is called before the first frame update
    void Start()
    {
       
    }
    private void Win()
    {
        Debug.Log("You Win");
    }
    private void Loose()
    {
        Debug.Log("You Loose");
    }
    // Update is called once per frame
    void Update()
    {
        if(_enemyCount.Value == 0)
        {
            Win();

        }
        else if (_currentPlayerHP.Value <= 0)
        {
            Loose();
        }
       
    }
}
