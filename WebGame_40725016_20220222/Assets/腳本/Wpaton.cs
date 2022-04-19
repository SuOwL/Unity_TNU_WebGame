using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Se
{ 

public class Wpaton : MonoBehaviour

     {

    [SerializeField, Header("武器資料")]
    private DataWeapon dataWeapon;

        private float timer;

        private void OnDrawGizmos()
        {
            
        }
        private void Start()
        {
            Physics2D.IgnoreLayerCollision(3, 6);
            Physics2D.IgnoreLayerCollision(6,6);
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

                timer = 0;
            }
            else
            {
                timer += Time.deltaTime;

            }

        }

        
    }
}
