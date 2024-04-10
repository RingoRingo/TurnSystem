using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ctrl : MonoBehaviour
{
    //private List<ItemPlayer> playList=new List<ItemPlayer>();

    private GameObject[] playList;
    /// <summary>
    /// 当前正在处理的玩家序列
    /// </summary>
    private int currectPlayerIndex = 0;
    // Start is called before the first frame update
    void Start()
    {
        GetAllCharacter();
        SortPlayerBySpeed();
    }

    // Update is called once per frame
    void Update()
    {
        if (currectPlayerIndex < playList.Length)
        {
            playList[currectPlayerIndex].GetComponent<ItemPlayer>().Order();
        }
    }


    private void GetAllCharacter() {
        playList = GameObject.FindGameObjectsWithTag("Player");
        //for (int i = 0; i < playList.Length; i++)
        //{
        //    Debug.Log($"speed={playList[i].GetComponent<ItemPlayer>().speed}");
        //}
    }

    /// <summary>
    /// 根据速度将所有玩家排序
    /// </summary>
    private void SortPlayerBySpeed() {
        for (int i = 0; i < playList.Length - 1; i++)
        {
            for (int j = i + 1; j < playList.Length; j++)
            {
                if (playList[i].GetComponent<ItemPlayer>().speed < playList[j].GetComponent<ItemPlayer>().speed)
                {
                    GameObject temp = playList[i];
                    playList[i] = playList[j];
                    playList[j] = temp;
                }
            }
        }

        for (int i = 0; i < playList.Length; i++)
        {
            Debug.Log($"speed={playList[i].GetComponent<ItemPlayer>().speed}");
        }
    }


}

public enum Team
{
    TeamA,
    TeamB,
}

public enum PlayerFightState { 
    Idle,
    Go,
    Attack,
    Back
}

