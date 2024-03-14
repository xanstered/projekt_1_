using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    public Weapon weapon1;
    public Weapon weapon2;
    public Weapon weapon3;

    // public WeaponRaw weaponRaw1 = new WeaponRaw(); //konstruktor czyli metoda kazdej klasy ktorego nie trzeba pisac bo automatycznie jest i ukryte jest 
    // public WeaponRaw weaponRaw2 = new WeaponRaw();

    public WeaponRaw weaponRaw1 = new WeaponRaw("AK47", 45);
    public WeaponRaw weaponRaw2 = new WeaponRaw("Luger", 8, true); //latwo tworzymy nowe obiekty dzieki konstruktorowi
    public WeaponRaw weaponRaw3 = new WeaponRaw("Sword", 1, Rarity.Legendary);

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(weapon1.weaponName + weapon1.ammo);
        Debug.Log(weapon2.weaponName + weapon2.ammo);

        // weaponRaw1.SetInfo("Luger", 8);
        // weaponRaw2.SetInfo("AK47", 45, true);

        Debug.Log(weaponRaw1.weaponName + weaponRaw1.ammo);
        Debug.Log(weaponRaw2.weaponName + weaponRaw2.ammo = weaponRaw2.isBoost);
        Debug.Log(weaponRaw3.weaponName + weaponRaw3.ammo = weaponRaw2.weaponRarity);
    }

    public enum Rarity // po prostu nazwane liczby i tyle i enum jest poza klas¹ i s¹ odrêbne dziêki czemu dzia³aj¹ do wszystkiego i nie trzeba przepisywaæ ich kilka razy
    {
        Common = 1,
        Uncommon,
        Rare,
        Super_Rare,
        Legendary
    }
}
