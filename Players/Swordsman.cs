using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swordsman : Playerstats
{

    [SerializeField] Goblin goblin;

    protected override void attack()
    {
        Debug.Log("Swordsman Attacks goblin");
        goblin.Health -= Attack;
        Debug.Log("Goblin Health: " +  goblin.Health); 
    }

    private void Start()
    {
        attack();
    }


}
