using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Icespellk : Spell
{
    public override void Cast()
    {
        base.Cast();
    }


    public void Start()
    {
        Cast2("ha ha stop that");
        Cast3("target is godzillar", 10);

        Debug.Log("ha ha stop that");
        Debug.Log("target is godzillar");
        Debug.Log("casting spell on slime wiyh power level is 10");


    }
}
