using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPlayer : MonoBehaviour
{
    public int HP;
    public int ATK;
    public int speed;
    public Team team;
    /// <summary>
    /// 敌人攻击自己时站位
    /// </summary>
    public Transform enemyPos;
    /// <summary>
    /// 战斗状态
    /// </summary>
    private PlayerFightState playerFightState=PlayerFightState.Idle;
    /// <summary>
    /// 攻击的目标玩家
    /// </summary>
    public GameObject TargetPlayer;

    void Awake() {
        HP= Random.Range(10000, 12000);
        ATK = Random.Range(2200, 3000);
        speed = Random.Range(800, 1200);
    }
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Transform GetEnemyPos() {
        return enemyPos;
    }

    public void Order() {
        if (playerFightState==PlayerFightState.Idle)
        {
            transform.LookAt(TargetPlayer.GetComponent<ItemPlayer>().GetEnemyPos());
        }
    }
}


