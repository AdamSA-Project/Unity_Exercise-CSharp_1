using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MagicDestroyer;

public class SpellCaster : MonoBehaviour
{
    public void Start()
    {

        Debug.Log("Nama : Adam Syafiq Aqil, NIM : 21210003, Kelas : 2C");

        Character Mages = new Character();
        Mages.AbilityPoint = 4;
        Debug.Log("Mage's Ability " + Mages.AbilityPoint);

        Character Necromancers = new Character();
        Necromancers.HealthPoint = 4;
        Debug.Log("Necromancer's Health Point " + Necromancers.HealthPoint);

        Character Druids = new Character();
        Druids.Weapon = "Knife";
        Debug.Log("Druid's Weapon Is" + Druids.Weapon);
    }

}
