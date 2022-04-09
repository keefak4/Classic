using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int damageBasic;
    private void OnCollisionEnter(Collision collision)
    {
        PlayerManager playerManager = collision.gameObject.GetComponent<PlayerManager>();
        if(playerManager != null)
        {
            playerManager.TakeDamage(damageBasic);
        }
    }
}
