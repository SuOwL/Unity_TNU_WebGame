using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Se
{
    public class EnemyHurt : HurtSystem
    {
        [SerializeField, Header("�ĤH���")]
        private DataEnemy data;

        private void Awake()
        {
            hp = data.hp;
        }
    
    }

}
