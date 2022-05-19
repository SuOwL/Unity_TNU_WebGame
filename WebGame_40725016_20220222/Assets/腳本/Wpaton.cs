using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Se
{ 

public class Wpaton : MonoBehaviour

     {

    [SerializeField, Header("武器資料")]
    private DataWeapon dataWeapon;
        [SerializeField, Header("武器刪除時間"), Range(0, 5)]
        private float weaponDestoryTime = 3.5f;

        

        private float timer;

        private void OnDrawGizmos()
        {
            Gizmos.color = new Color(1, 0, 0, 0.5f);

            for (int i = 0; i < dataWeapon.v2SpawnPoint.Length; i++)
            {
                Gizmos.DrawSphere(transform.position + dataWeapon.v2SpawnPoint[i], 0.1f);
            }
         }

       

        private void Start()
        {
            Physics2D.IgnoreLayerCollision(3, 6);
            Physics2D.IgnoreLayerCollision(6, 6);
            Physics2D.IgnoreLayerCollision(6, 7);
        }

        private void Update()
            {
            SpawnWeapon();
            }


        private void SpawnWeapon()
        {
            print("經過時間:" + timer);

            if(timer >= dataWeapon.interval)
            {
                int random = Random.Range(0, dataWeapon.v2SpawnPoint.Length);

                Vector3 pos = transform.position + dataWeapon.v2SpawnPoint[random];

                GameObject temp = Instantiate(dataWeapon.goWeapon, pos, Quaternion.identity);

                temp.GetComponent<Rigidbody2D>().AddForce(dataWeapon.v3Direction * dataWeapon.speedFly);
                temp.GetComponent<Weapon>().attack = dataWeapon.attack;

                timer = 0;

                Destroy(temp, weaponDestoryTime);
            }
            else
            {
                timer += Time.deltaTime;

            }

        }

        
    }
}
