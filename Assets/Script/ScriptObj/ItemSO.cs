using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSO : ScriptableObject
{
    [SerializeField]
    private Sprite icon;
    [SerializeField]
    private string names;
    [SerializeField]
    private string decription;
    [SerializeField]
    private float damage;
    [SerializeField]
    private int price;

    public Sprite Icon
    {
        get
        {
            return icon;
        }
    }
    public string Names
    {
        get
        {
            return names;
        }
    }
    public string Decription
    {
        get
        {
            return decription;
        }
    }
    public float Damage
    {
        get
        {
            return damage;
        }
    }
    public int Price
    {
        get
        {
            return price;
        }
    } 
}
