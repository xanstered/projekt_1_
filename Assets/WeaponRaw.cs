using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponRaw
{
    public string weaponName;
    public int ammo;

    public void SetInfo(string p_name, int p_ammo)
    {
        weaponName = p_name;
        ammo = p_ammo;
    }

    public void SetInfo(string p_name, int p_ammo, bool p_isBoost) //klucz wystêpowania, przeci¹¿anie metod, do parametrow EWNTUALNYCH  
    {
        weaponName = p_name;
        ammo = p_ammo;
    }

}