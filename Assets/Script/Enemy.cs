using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int damageBasic;
    private void OnTriggerEnter(Collider other)
    {
        PlayerManager playerManager = other.GetComponent<PlayerManager>();
        if(playerManager)
        {
            playerManager.TakeDamage(damageBasic);
        }    
    }
}
