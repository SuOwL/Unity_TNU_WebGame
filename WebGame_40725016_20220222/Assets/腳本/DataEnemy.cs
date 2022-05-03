using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Se

{


    [CreateAssetMenu(menuName = "Se/Data Enemy", fileName = "Data Enemy")]
    public class DataEnemy : ScriptableObject

    {
        [Header("移動速度"), Range(0, 3500)]
        public float speed = 500;
        [Header("攻擊力"), Range(0, 1000)]
        public float attack = 10;
        [Header("攻擊冷卻"), Range(0, 5)]
        public float cd = 3.5f;
        [Header("血量"), Range(0, 5000)]
        public float hp = 100;
        [Header("掉落經驗機率"), Range(0, 1)]
        public float expDropProbability = 100;
        [Header("掉落經驗機率")]
        public TypeExp typeExp;
        [Header("靠近目標後停止距離"), Range(0, 30)]
        public float stopDistance = 3;


    }
    public enum TypeExp
    {
        small,middle,big
    }
}

