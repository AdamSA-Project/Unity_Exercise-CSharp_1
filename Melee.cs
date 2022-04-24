using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MagicDestroyer;

public class Melee : MonoBehaviour
{
    public void Start()
   {
       Character Warrior = new Character();
       Warrior.Level = 4;
       Debug.Log("Warrior Level Is " + Warrior.Level);

       Character Knight = new Character();
       Knight.Name = "Knight";
       Debug.Log("Knight Name Is " + Knight.Name);

       Character Assasin = new Character();
       Assasin.Weapon = "Knife";
       Debug.Log("Assasin Weapon Is " + Assasin.Weapon);
   }
}
