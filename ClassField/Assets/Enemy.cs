using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update


    //認識第一個成員:欄位field - 儲存物件資料
    //資料類型
    //血量   - 100 - 整數 int
    //魔力   - 100 - 整數 int  
    //移動速度 - 10.5 - 浮點數 float
    //攻擊力   -50-  整數 int
    //防禦力-  -50-  整數 int
    //武器名稱 -  字串 string
    //裝備名稱 -皮衣 -  字串 string
    //是否帶有鑰匙    -是否開啟   -布林值bool
    //是否掉落寶物    -是否開啟   -布林值bool

    //定義欄位語法:
    // 修飾詞資料類型 欄位名稱;
    //公開public:允許其他類別存取,顯示在屬性面板(Inspector)
    //私人private(預設):不允許,不顯示
    //int ,float為0
    //string為""
    //bool為false
    //欄位屬性attribute:Unity 提供用於輔助欄位的功能
    //語法:[屬性名稱值(值)]
    //標題[Header(字串)]
    //範圍[Range(最大值,最小值)],僅限於數值類型資料 int,float
    /// <summary>
    /// 怪物的血量
    /// </summary>
    [Header("怪物的血量"), Tooltip("怪物的血量"),Range(50,500)]
    public int 血量 = 100;
    /// <summary>
    /// 怪物的魔力
    /// </summary>
    [Header("怪物的魔力"), Tooltip("這個欄位是存放怪物的魔力"), Range(10, 100)]
    public int 魔力 = 100;
    /// <summary>
    /// 移動速度
    /// </summary>
    [Header("能力值") , Tooltip("這個欄位是存放怪物的移動速度"), Range(1 , 50.5f)]
    public float 移動速度 = 10.5f;
    /// <summary>
    /// 怪物攻擊力
    /// </summary>
    [Header("能力值"), Tooltip("這個欄位是存放怪物的攻擊力"), Range(20, 200)]
    public int 攻擊力 = 100;
    /// <summary>
    /// 怪物防禦力
    /// </summary>
    [Header("能力值"), Tooltip("這個欄位是存放怪物的防禦力"), Range(0, 100)]
    public int 防禦力 = 100;
    /// <summary>
    /// 武器名稱
    /// </summary>
    [Header("裝備"), Tooltip("這個欄位是存放武器名稱")]
    public string  武器=("小刀") ;
    /// <summary>
    /// 裝備名稱
    /// </summary>
    [Header("裝備"), Tooltip("這個欄位是存放裝備名稱")]
    public string 防具="皮衣";
    /// <summary>
    /// 是否帶有鑰匙
    /// </summary>
    [Header("其他資料"), Tooltip("這個欄位是描述怪物是否帶有鑰匙")]
    public bool 鑰匙 = false;
    /// <summary>
    /// 是否掉落寶物
    /// <summary>
    [Header("其他資料"), Tooltip("判定怪物是否掉落寶物")]
    public bool 寶物 = false;
}
    

    // Update is called once per frame
    
    
        
    

