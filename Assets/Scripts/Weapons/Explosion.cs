using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Weapons;

public static class Explosion
{
    public static List<IDamageable> Trigger(Vector3 center, float radius, int mask, float damage)
    {
        List<IDamageable> damageables = null;

        Collider[] colliders = Physics.OverlapSphere(center, radius, mask, QueryTriggerInteraction.Ignore);

        if (colliders.Length > 0)
        {
            foreach (Collider collider in colliders)
            {
                if (collider.TryGetComponent(out IDamageable damageable))
                {
                    damageable.TakeDamage(damage);
                    damageables.Add(damageable);
                }
            }
        }

        return damageables;
    }
}
