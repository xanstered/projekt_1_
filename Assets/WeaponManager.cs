using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    public Weapon weapon1;
    public Weapon weapon2;

    public WeaponRaw weaponRaw1 = new WeaponRaw();
    public WeaponRaw weaponRaw2 = new WeaponRaw();

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(weapon1.weaponName + weapon1.ammo);
        Debug.Log(weapon2.weaponName + weapon2.ammo);

        weaponRaw1.SetInfo("Luger", 8);
        weaponRaw2.SetInfo("AK47", 45, true);

        Debug.Log(weaponRaw1.weaponName + weaponRaw1.ammo);
        Debug.Log(weaponRaw2.weaponName + weaponRaw2.ammo);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
