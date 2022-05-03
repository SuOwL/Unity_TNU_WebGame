using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Se
{ 
public class HurtSystem : MonoBehaviour
  {
    [SerializeField, Header("血量"), Range(0, 10000)]
    protected float hp;


    public void GetHurt(float damage)
    {
        hp -= damage;
        print("<color=pink>收到的傷害:" + damage + "</color>");

        if (hp <= 0) Dead();
    }
    private void Dead()
    {
        hp = 0;
        print("<color=pink>角色死亡:" + gameObject + "</color>");
    }
  }
}
