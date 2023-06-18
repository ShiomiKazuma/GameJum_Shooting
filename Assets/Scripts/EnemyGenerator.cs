using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    //��������G
    [SerializeField] GameObject _enemynormal;
    [SerializeField] GameObject _enemyboss;

    //��������ʒu
    [SerializeField] List<Vector3> _enemyPos;

    private float time;
    [SerializeField] public float timeOut;       // ��������Ԋu


    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if (time >= timeOut)
        {
            time = 0.0f;

            // �����_���Ŏ�ނƈʒu�����߂�
            int index = Random.Range(0, _enemyPos.Count);

            Instantiate(_enemynormal, _enemyPos[index], Quaternion.identity);
        }
    }
}
