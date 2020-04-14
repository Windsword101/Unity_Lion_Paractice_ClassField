using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("怪物一號")]
    public Enemy enemy1;
    [Header("怪物二號")]
    public Enemy enemy2;
    //事件:在特定時間會已指定次數執行的方法(名稱為藍色)
    //開始事件:播放遊戲時執行一次- 初始設定
    private void Start()
    
    { 
        print("怪物一號的魔力" +enemy1.魔力);
        print("怪物二號的裝備名稱" + enemy2.武器) ;
        enemy1.血量 = 100;
        enemy2.血量 = 300;
        enemy1.防禦力 = 50;
        enemy1.武器 = "木棍";
        enemy2.武器 = "短刀";
        enemy1.鑰匙=true ;
        enemy2.寶物=true ;

    }


    // Update is called once per frame




}
