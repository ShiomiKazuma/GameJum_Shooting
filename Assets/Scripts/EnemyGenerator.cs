using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    //¶¬‚·‚é“G
    [SerializeField] GameObject _enemynormal;
    [SerializeField] GameObject _enemyboss;

    //¶¬‚·‚éˆÊ’u
    [SerializeField] List<Vector3> _enemyPos;
    [SerializeField] Vector3 _bosPos;

    private float time;
    [SerializeField] public float timeOut;       // ¶¬‚·‚éŠÔŠu

    GameManager gamemanager;

    bool enemy = true;

    private void Start()
    {
        gamemanager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if(gamemanager._boss_frag && enemy)
        {
            Instantiate(_enemyboss, _bosPos, Quaternion.identity);
            enemy = false;
        }
        else
        {
            if (time >= timeOut)
            {
                time = 0.0f;

                // ƒ‰ƒ“ƒ_ƒ€‚Åí—Ş‚ÆˆÊ’u‚ğŒˆ‚ß‚é
                int index = UnityEngine.Random.Range(0, _enemyPos.Count);

                Instantiate(_enemynormal, _enemyPos[index], Quaternion.identity);
            }
        }
        
    }
}
