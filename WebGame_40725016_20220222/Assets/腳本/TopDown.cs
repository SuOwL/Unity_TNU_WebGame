using UnityEngine;

namespace ������
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
            print("�����b�V��" + h);
        }
    }
}
