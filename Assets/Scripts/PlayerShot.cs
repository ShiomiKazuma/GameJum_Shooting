using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShot : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    Vector3 bulletPoint;
    //[SerializeField] private float timeOut;
    //private float time;

    // Start is called before the first frame update
    void Start()
    {
        bulletPoint = transform.Find("BulletPoint").localPosition;

    }

    // Update is called once per frame
    void Update()
    {
        //time += Time.deltaTime;

        if (Input.GetButtonDown("Fire1"))
        {
            AudioManager.Instance.PlaySE(AudioManager.SESoundData.SE.Shot);
            // íeÇÃê∂ê¨
            Instantiate(bullet, transform.position + bulletPoint, Quaternion.identity);

            //time = 0.0f;
        }
    }
}
