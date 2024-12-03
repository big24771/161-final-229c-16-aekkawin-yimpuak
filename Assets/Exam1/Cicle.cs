using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cicle : Shape
{
    private float radious;

    public override void Calculaterrea2(float nom)
    {
        radious *= radious;
        radious = nom;
        return;

    }
    public override void Resize()
    {
        base.Resize();
    }

    void Start()
    {
        radious = 5;
        shapeName = "cicle";
        Resize();
        Draw();
        Debug.Log($" cicle {radious}");
    }


}
