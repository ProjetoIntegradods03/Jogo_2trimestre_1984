using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDamage : MonoBehaviour
{
    [SerializeField]
    [Min(0)]
    private int damage = 10;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Idamageable damageable = collision.GetComponent<Idamageable>();
        if (damageable != null)
        {
            damageable.TakeDamage(damage);
        }
    }
}
