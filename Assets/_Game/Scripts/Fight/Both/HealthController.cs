using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthController : MonoBehaviour
{
    [SerializeField]
    private Creature _creature;

    public void TakeDamage(int damage)
    {
         _creature.stats.health -= damage;
        if(IsDie())
        {
            Die();
        }
    }

    private bool IsDie()
    {
        if(_creature.stats.health <= 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    private void Die()
    {
        gameObject.SetActive(false);
    }
}
