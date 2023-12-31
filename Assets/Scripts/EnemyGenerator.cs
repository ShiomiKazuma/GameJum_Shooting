using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    //生成する敵
    [SerializeField] GameObject _enemynormal;
    [SerializeField] GameObject _enemyboss;

    //生成する位置
    [SerializeField] List<Vector3> _enemyPos;
    [SerializeField] Vector3 _bosPos;

    private float time;
    [SerializeField] public float timeOut;       // 生成する間隔

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

                // ランダムで種類と位置を決める
                int index = UnityEngine.Random.Range(0, _enemyPos.Count);

                Instantiate(_enemynormal, _enemyPos[index], Quaternion.identity);
            }
        }
        
    }
}
