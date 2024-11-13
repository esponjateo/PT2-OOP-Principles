using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Playerstats : MonoBehaviour
{

    [SerializeField] protected int Health;
    [SerializeField] protected int Mana;
    [SerializeField] protected int Attack;
    [SerializeField] protected int Defence;
    [SerializeField] protected float Speed;
    [SerializeField] protected float Luck;

    protected abstract void attack();

}
