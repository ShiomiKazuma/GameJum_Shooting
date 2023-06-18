using UnityEngine;

public class BossBulletMove : MonoBehaviour
{
    [SerializeField]
    private int Attack = 0;

    [SerializeField]
    private float _bulletSpeed = -0.05f;

    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(0, _bulletSpeed, 0);

        if (transform.position.y < -10)
        {
            Destroy(gameObject);
        }
    }
}
