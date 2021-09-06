using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityDurability : MonoBehaviour
{
    [SerializeField] private int health, maxHealth;

    [SerializeField] private DamageResistances profile;

    private void Start()
    {
        health = maxHealth;
    }

    public void DealDamage(int damage, Elements element)
    {
        health -= profile.CalculateDamageWithResistance(damage, element);

        if (health <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
