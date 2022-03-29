using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Se
{ 

public class Wpaton : MonoBehaviour

     {

    [SerializeField, Header("ªZ¾¹¸ê®Æ")]
    private DataWeapon dataWeapon;
    
        private void OnDrawGizmos()
        {
            Gizmos.color = new Color(1, 0, 0, 0.5f);

            Gizmos.DrawSphere(transform.position + dataWeapon.v2SpawnPoint[0], 0.1f);
        }

        
    }
}
