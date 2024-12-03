using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newspell : Spell
{
    public override void Cast()
    {
        base.Cast();
    }


    public void Start()
    {
        Cast2("time to sleep");
        Cast3("target is fox!", 100);

        Debug.Log("time to sleep");
        Debug.Log("target is fox!");
        Debug.Log("casting spell on slime wiyh power level is 100");


    }

}
