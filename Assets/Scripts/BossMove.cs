using UnityEngine;
using UnityEngine.SceneManagement;

public class BossMove : MonoBehaviour
{
    public GameObject _bullet;

    private float _shot_interval_count;

    private bool attack_flag = false;

    [SerializeField] float _pos_x;

    [SerializeField]
    private int _hp = 10;

    // Vector3 bossBulletPoint;


    // Start is called before the first frame update
    void Start()
    {
        _shot_interval_count = 0.0f;

        Debug.Log(transform.lossyScale);

        // bossBulletPoint = transform.Find("BossBulletPoint").localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        // 
        if (!attack_flag)
        {
            attack_flag = true;
        }
        else
        {
            transform.position = new Vector3(transform.position.x + _pos_x, transform.position.y, transform.position.z);

            if (transform.position.x > 2 || transform.position.x < -2)
            {
                _pos_x *= -1f;
            }

            _shot_interval_count += Time.deltaTime;

            if (_shot_interval_count > 0.5f)
            {
                Instantiate(_bullet, this.transform.position - new Vector3(0, transform.lossyScale.y, 0), Quaternion.identity);
                _shot_interval_count = 0.0f;
            }
        }

        // HPÇ™0Ç…Ç»Ç¡ÇΩÇÁè¡Ç∑
        if (_hp <= 0)
        {
            AudioManager.Instance.PlaySE(AudioManager.SESoundData.SE.Boss);
            Destroy(gameObject);
            SceneManager.LoadScene("Clear");
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "bullet")
        {
            _hp = _hp - 1;
        }
    }
}
