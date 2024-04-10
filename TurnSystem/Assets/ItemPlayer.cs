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
        switch (playerFightState)
        {
            case PlayerFightState.Idle:
                break;
            case PlayerFightState.Go:
                break;
            case PlayerFightState.Attack:
                break;
            case PlayerFightState.Back:
                break;
        }
    }
    /// <summary>
    /// 获取敌人需要的站位
    /// </summary>
    /// <returns></returns>
    public Transform GetEnemyPos() {
        return enemyPos;
    }
    /// <summary>
    /// 进行操作指令
    /// </summary>
    public void Order() {
        if (playerFightState==PlayerFightState.Idle)
        {
            Vector3 v3 = new Vector3(TargetPlayer.GetComponent<ItemPlayer>().GetEnemyPos().position.x,
                transform.position.y,
                TargetPlayer.GetComponent<ItemPlayer>().GetEnemyPos().position.z);
            transform.LookAt(v3);
            playerFightState = PlayerFightState.Go;
        }
    }
}


