using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public List<Weapon> weapons = new List<Weapon>();
    public Weapon[] EquippedWeapons = new Weapon[2];

    public void AddWeapon(WeaponType type)
    {
        weapons.Add(Weapon.CreatWeapon(type));
    }

}
