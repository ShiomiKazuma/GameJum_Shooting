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

    private float time;
    [SerializeField] public float timeOut;       // 生成する間隔


    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if (time >= timeOut)
        {
            time = 0.0f;

            // ランダムで種類と位置を決める
            int index = Random.Range(0, _enemyPos.Count);

            Instantiate(_enemynormal, _enemyPos[index], Quaternion.identity);
        }
    }
}
