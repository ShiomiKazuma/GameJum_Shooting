using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShot : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    Vector3 bulletPoint;

    // Start is called before the first frame update
    void Start()
    {
        bulletPoint = transform.Find("BulletPoint").localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            // �e�̐���
            Instantiate(bullet, transform.position + bulletPoint, Quaternion.identity);
        }
    }
}
