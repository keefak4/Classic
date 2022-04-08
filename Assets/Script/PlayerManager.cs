using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : BasjcComponent
{
    public  int helthMax = 10;
    public int helth = 10;
    [Space]
    public int energyMax = 10;
    public int energy = 10;

    public void TakeDamage(int damage)
    {
        helth -= damage;
        if(helth <= 0)
        {
            ReciewDamage();
        }
    }
}
