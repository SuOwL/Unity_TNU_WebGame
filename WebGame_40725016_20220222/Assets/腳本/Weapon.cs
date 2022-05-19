using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Se
{
    public class Weapon : MonoBehaviour
    {
        [HideInInspector]
        public float attack;

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if(collision.gameObject.tag == "¼Ä¤H")

            {


               collision.gameObject.GetComponent<HurtSystem>().GetHurt(attack);
                Destroy(gameObject);
            }
        }
    }
}


