using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //�v���C���[��hp
    [SerializeField] public int _maxhp = 10;
    public int _playerhp;

    //���j��
    [SerializeField] public int _targetscore;
    //���j�ڕW
    [SerializeField] int _targetgoal = 3;

    //�{�X�t���O
    public bool _boss_frag = false;


    // Start is called before the first frame update
    void Start()
    {
        AudioManager.Instance.PlayBGM(AudioManager.BGMSoundData.BGM.Game);
        
        //����������
        _targetscore = 0;

        _playerhp = _maxhp;

    }

    // Update is called once per frame
    void Update()
    {
        if(_playerhp <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }

        if(_targetscore >= _targetgoal) 
        {
            Debug.Log("Instance");
            _boss_frag = true;
        }

    }

    public void EnemyDestory()
    {
        _targetscore = _targetscore + 1;
    }

    public void HitEnemy()
    {
        _playerhp = _playerhp - 1;
    }

    private void GameClear()
    {
        SceneManager.LoadScene("GameClear");
    }
}
