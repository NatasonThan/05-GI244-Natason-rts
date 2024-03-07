using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rifle : Weapon
{
    public Rifle()
    {
        Type = WeaponType.Rifle;
    }
    public override WeaponStats GetStats()
    {
        return new WeaponStats {damage = 30, fireRate = 0.7f, ammo = 10};
    }

    public override void Fire()
    {
        Debug.Log("Firing rifle");
    }

    public override void Reload()
    {
        Debug.Log("Reload rifle");
    }
}
