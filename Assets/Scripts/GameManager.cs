using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //プレイヤーのhp
    [SerializeField] public int _maxhp = 10;
    public int _playerhp;

    //撃破数
    [SerializeField] public int _targetscore;
    //撃破目標
    [SerializeField] int _targetgoal = 3;

    //ボスフラグ
    public bool _boss_frag = false;


    // Start is called before the first frame update
    void Start()
    {
        //初期化する
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
            _boss_frag = true;
        }

    }

    private void OnDestroy()
    {
        _targetscore = _targetscore + 1;
    }

    void HitEnemy()
    {
        _playerhp = _playerhp - 1;
    }

    private void GameClear()
    {
        SceneManager.LoadScene("GameClear");
    }
}
