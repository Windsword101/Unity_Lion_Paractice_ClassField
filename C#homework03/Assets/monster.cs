using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monster : MonoBehaviour
{
    /// <summary>
    ///魔物名稱 
    /// </summary>
    public string monstername;
    /// <summary>
    /// 最大血量
    /// </summary>
    public int maxhp;
    /// <summary>
    /// 魔物的攻擊力
    /// </summary>
    public int atk;
    /// <summary>
    /// 治癒血量
    /// </summary>
    public int heal;
    /// <summary>
    /// 當前血量
    /// </summary>
    public int currentHP;
    /// <summary>
    /// 攻擊狀態
    /// </summary>
    public string currentstate;

}
