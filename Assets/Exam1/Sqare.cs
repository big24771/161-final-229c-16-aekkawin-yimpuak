using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Suare : Shape
{

    private float side;

    public override void Calculaterrea2(float nom)
    {
        side *= side;
        side = nom;
        
        return;

    }
    public override void Resize()
    {
        base.Resize();
    }

    void Start()
    {
        side = 5;
        shapeName = "cicle";
        Resize();
        Draw();
        Debug.Log($" Square {side}");
    }
}
