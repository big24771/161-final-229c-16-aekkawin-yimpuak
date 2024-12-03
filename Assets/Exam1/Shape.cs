using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Shape : MonoBehaviour
{
    protected string shapeName;

    public void Init(string anser)
    { 
    
    }

    public  void Calculaterrea(float nom)
    {
        
    
    }

    public virtual void Calculaterrea2(float nom)
    {


    }


    public virtual void Resize()
    {
        Debug.Log($"Resized Shape");
        Debug.Log($"{shapeName} is resized");
    
    }

    public void Draw()
    {
        Debug.Log($"drawing{shapeName}");
    
    
    }
    
        
    
}
