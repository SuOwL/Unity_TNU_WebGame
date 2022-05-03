using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Se

{


    [CreateAssetMenu(menuName = "Se/Data Enemy", fileName = "Data Enemy")]
    public class DataEnemy : ScriptableObject

    {
        [Header("���ʳt��"), Range(0, 3500)]
        public float speed = 500;
        [Header("�����O"), Range(0, 1000)]
        public float attack = 10;
        [Header("�����N�o"), Range(0, 5)]
        public float cd = 3.5f;
        [Header("��q"), Range(0, 5000)]
        public float hp = 100;
        [Header("�����g����v"), Range(0, 1)]
        public float expDropProbability = 100;
        [Header("�����g����v")]
        public TypeExp typeExp;
        [Header("�a��ؼЫᰱ��Z��"), Range(0, 30)]
        public float stopDistance = 3;


    }
    public enum TypeExp
    {
        small,middle,big
    }
}

