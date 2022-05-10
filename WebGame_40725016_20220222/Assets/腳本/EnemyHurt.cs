using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Se
{
    public class EnemyHurt : HurtSystem
    {
        [SerializeField, Header("�ĤH���")]
        private DataEnemy data;
        [SerializeField, Header("�e���ˮ`�ƭ�")]
        private GameObject goCanvasHurt;

        private string parameterDead = "Ĳ�o���`";
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
