using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class enemy : MonoBehaviour
{
    [SerializeField] 
    private float speed = -0.01f;

    [SerializeField]
    private float shot_interval = 1.0f;

    public GameObject enemy_bullet;

    private Vector3 enemy_bulletpoint;

    private float enemy_shot_interval_count;

    GameManager gamemanager;

    // Start is called before the first frame update
    void Start()
    {
        enemy_bulletpoint = transform.Find("bulletpoint_enemy").localPosition;
        //var enemy = transform.position = new Vector3( 0, 0, 0);

        enemy_shot_interval_count = 0f;

        gamemanager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        // 弾の発射
        enemy_shot_interval_count += Time.deltaTime;

        if (enemy_shot_interval_count > shot_interval)
        {
            Instantiate(enemy_bullet, transform.position + enemy_bulletpoint, Quaternion.identity);
            enemy_shot_interval_count = 0f;
        }

        //エネミー　移動
        transform.Translate(0, speed, 0);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "gameout")
        {
            BulletDestroy();
        }

        if(collision.gameObject.tag == "bullet")
        {
            gamemanager.EnemyDestory();
            BulletDestroy();
        }
    }
    private void BulletDestroy()
    {
        AudioManager.Instance.PlaySE(AudioManager.SESoundData.SE.Shot);
        Destroy(gameObject);
    }
}
