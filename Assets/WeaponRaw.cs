using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponRaw
{
    public string weaponName;
    public int ammo;
    public bool isBoost;
    public Rarity weaponRarity;

    public WeaponRaw(string p_name, int p_ammo)
    {
        weaponName = p_name;    
        ammo = p_ammo;
    }

    public WeaponRaw(string p_name, int p_ammo, bool p_isBoost)
    {
        weaponName = p_name;
        ammo = p_ammo;
        isBoost = p_isBoost;
    }
    
    public WeaponRaw(string p_name, int p_ammo, Rarity p_rarity)
    {
        weaponName = p_name;
        ammo = p_ammo * (int)p_rarity; //int wylicza enum
        weaponRarity = p_rarity;
    }

    // public void SetInfo(string p_name, int p_ammo, bool p_isBoost) to klucz wystêpowania, przeci¹¿anie metod, do parametrow EWNTUALNYCH  

}