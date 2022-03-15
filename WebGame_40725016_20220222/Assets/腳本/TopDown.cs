using UnityEngine;

namespace 陳灝融
{


    public class TopDown : MonoBehaviour


    {
   
        private Animator ani;
        private Rigidbody2D rig;
       

        private void Awake()
        {
            ani = GetComponent<Animator>();
            rig = GetComponent<Rigidbody2D>();
        }

        private void Undate()
        {
            float h = Input.GetAxis("Horizontal");
            print("水平軸向值" + h);
        }
    }
}
