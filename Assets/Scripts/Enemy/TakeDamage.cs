using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeDamage : MonoBehaviour
{
    [SerializeField] private EnemyHealth _enemyHealth;

    void OnTriggerEnter(Collider other)
    {
        if(other.attachedRigidbody)
        {
            Debug.Log(other.attachedRigidbody.name);
            BulletTrigger bullet = other.attachedRigidbody.GetComponent<BulletTrigger>();
            if(bullet && other.attachedRigidbody.name == "PlayerBullet(Clone)")
            {
                bullet.DestroyBullet();
                _enemyHealth.TakeDamage(1);
            }
        }
    }
}
