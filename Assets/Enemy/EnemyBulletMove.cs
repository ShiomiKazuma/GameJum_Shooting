using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class EnemyBulletMove : MonoBehaviour
{
    [SerializeField]
    private float enemy_bulletSpeed = -0.05f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, enemy_bulletSpeed, 0);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "gameout")
        {
            BulletDestroy();
        }
    }
    private void BulletDestroy()
    {
        Destroy(gameObject);
    }
}
