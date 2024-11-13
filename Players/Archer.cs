using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Archer : Playerstats
{
    [SerializeField] Mercenary mercenary;

    protected override void attack()
    {
        Debug.Log("Archer Attacks Mercenary");
        mercenary.Health -= Attack;
        Debug.Log("Mercenary Health: " + mercenary.Health);
    }

    private void Start()
    {
        attack();
    }
}
