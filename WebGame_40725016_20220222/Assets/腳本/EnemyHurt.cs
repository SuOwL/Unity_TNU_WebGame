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
        [SerializeField, Header("�g��ȹD��")]
        private GameObject goExp;

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
            temp.GetComponent<HurtNumberEffect>().UpdateDamage(damage);
        }
        private override void Dead()
        {
            base.Dead();
            ani.SetTrigger(parameterDead);

            enemySystem.enabled = false;
            GetComponent<Collider2D>().enabled = false;
            Destroy(gameObject, 1.5f);

            DropExp();
        }
    

        private void  DropExp()
        {
            float random = Random.value;

            if(random <= data.expDropProbability)
            {
                GameObject tempExp = Instantiate(goExp, transform.position, Quaternion.identity);
                tempExp.AddComponent<Exp>().typeExp = data.typeExp;
            }
            
        }
    
}

}
