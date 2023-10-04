using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackArea : MonoBehaviour
{
    private int damage = 10;
    private void OnTriggerEnter(Collider collider)
    {
        if(collider.GetComponent<EnemyHealth>() != null)
        {
            EnemyHealth health = collider.GetComponent<EnemyHealth>();
            health.Damage(damage);
        }
    }
}
