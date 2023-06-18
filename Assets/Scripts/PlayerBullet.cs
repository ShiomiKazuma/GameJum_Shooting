using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    //弾丸のスピード
    [SerializeField] float MoveSpeed = 20.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // 位置の更新
        transform.Translate(0, MoveSpeed * Time.deltaTime, 0);
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
