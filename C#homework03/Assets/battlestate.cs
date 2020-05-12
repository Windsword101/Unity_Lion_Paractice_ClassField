using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class battlestate : MonoBehaviour
{
    public monster bat;
    public monster slime;
    public Text result;

    /// <summary>
    /// 魔物蝙蝠攻擊
    /// </summary>
    public void BatAttack()
    {
        slime.currentHP = slime.currentHP - bat.atk;
        result.text = "史萊姆所受攻擊" + bat.atk+"\n"+"史萊姆當前血量"+slime.currentHP;
    }
    /// <summary>
    /// 魔物史萊姆攻擊
    /// </summary>
    public void SlimeAttack()
    {
        bat.currentHP = bat.currentHP - slime.atk;
        result.text = "<Color=#243224>"+"蝙蝠-所受攻擊"+ "</Color>" + slime.atk + "\n" + "<Color=#243224>"+ "蝙蝠-當前血量" + "</Color>" + bat.currentHP;
    }
    /// <summary>
    /// 魔物蝙蝠治癒
    /// </summary>
    public void BatHeal()
    {
        bat.currentHP = bat.currentHP + bat.heal;
        result.text = "蝙蝠治癒" + bat.heal + "\n" + "蝙蝠當前血量" + bat.currentHP;
    }
    /// <summary>
    /// 魔物史萊姆治癒
    /// </summary>
    public void slimeHeal()
    {
        slime.currentHP = slime.currentHP + slime.heal;
        result.text = "史萊姆治癒" + slime.heal + "\n" + "史萊姆當前血量" + slime.currentHP;
    }


       

}
