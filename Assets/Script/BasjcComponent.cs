using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasjcComponent : MonoBehaviour
{
    public virtual void ReciewDamage()
    {
        Die();
    }
    private void Die()
    {
        Destroy(gameObject);
    }
}
