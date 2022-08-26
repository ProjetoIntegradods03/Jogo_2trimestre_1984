using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathOnDamage : MonoBehaviour, Idamageable
{
    public void TakeDamage(int damage)
    {
        Destroy(gameObject);
    }
}
