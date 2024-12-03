using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firespell : Spell
{
    public override void Cast()
    {
        base.Cast();
    }
    

    public void Start()
    {
        Cast2("burn them all");
        Cast3("target is unicorn", 5);

        Debug.Log("burn them all");
        Debug.Log("target is slime!");
        Debug.Log("casting spell on slime wiyh power level is 5");
        
        
    }
}
