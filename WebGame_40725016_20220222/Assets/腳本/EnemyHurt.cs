using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Se
{
    public class EnemyHurt : HurtSystem
    {
        [SerializeField, Header("敵人資料")]
        private DataEnemy data;
        [SerializeField, Header("畫布傷害數值")]
        private GameObject goCanvasHurt;

        private string parameterDead = "觸發死亡";
        private Animator ani;

        private void Awake()
        {
            ani = GetComponent<Animator>();

            hp = data.hp;
        }
    
        private override void GetHurt(float damage)
        {
            base.GetHurt(damage);

            GameObject temp =Instantiate(goCanvasHurt, transform.position, Quaternion.identity);
            temp,GetComponent<HurtNumberEffect>().UpdateDamage(damage);
        }
        private override void Dead()
        {
            base.Dead();
            ani.SetTrigger(parameterDead);
        }
    }

}
