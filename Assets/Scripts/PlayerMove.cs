using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    //���@�̃X�s�[�h
    [SerializeField] public float _speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // ���L�[�̓��͏����擾����
        var h = Input.GetAxis("Horizontal");
        var v = Input.GetAxis("Vertical");

        // ���L�[��������Ă�������Ƀv���C���[���ړ�����
        var velocity = new Vector3(h, v) * _speed;
        transform.localPosition += velocity;
    }
}

