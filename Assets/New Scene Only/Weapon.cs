using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum WeaponType
{
    Pistol,
    Rifle,
    Shotgun
}

public struct WeaponStats
{
    public int damage;
    public float fireRate;
    public int ammo;
}

public abstract class Weapon : MonoBehaviour
{
    private WeaponType type;
    public WeaponType Type
    {
        get { return type;}
        set { type = value; }
    }
    public abstract WeaponStats GetStats();
    public abstract void Fire();
    public abstract void Reload();

    public static Weapon CreatWeapon(WeaponType type)
    {
        Weapon weapon = null;
        switch (type)
        {
            case WeaponType.Pistol: 
                //weapon = new Pistol();
                return Instantiate(new Pistol());
                break;
            case WeaponType.Rifle:
                weapon = new Rifle();
                break;
            default: Debug.Log("Invalid Weapon Type!");
                break;
        }
        return weapon;
    }
}
