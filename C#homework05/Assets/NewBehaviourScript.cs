using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public SpriteRenderer kid;

    public Rigidbody ball;
    private void Start()
    {
        //練習一:靜態屬性
        Time.timeScale = 2;
        //練習二:非靜態屬性
        kid.flipX = true;
        //練習三
        print(Mathf.Floor(1.234567f));
        //練習四
        ball.AddForce(0, 800, 1200);
        ball.AddExplosionForce (50,new Vector3(0, 0, 0),50, 3.0F);




    }
    
}
