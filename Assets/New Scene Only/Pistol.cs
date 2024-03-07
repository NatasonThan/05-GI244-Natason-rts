using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : Weapon
{
    public Pistol()
    {
        Type = WeaponType.Pistol;
    }

    public override WeaponStats GetStats()
    {
        return new WeaponStats {damage = 20, fireRate = 0.5f, ammo = 10};
    }

    public override void Fire()
    {
        Debug.Log("Firing pistol");
    }

    public override void Reload()
    {
        Debug.Log("Reload pistol");
    }
}
