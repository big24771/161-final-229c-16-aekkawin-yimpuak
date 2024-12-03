using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Spell : MonoBehaviour
{
    public void Awake()
    {
        Debug.Log("Spell casting simulate start!");
        Debug.Log("get a generic spell!");
    }
   
    public virtual void Cast()
    {
        
    }

     public  void Cast2 ( string Cast)
    { 
    
    
    }

    public void Cast3(string iscast , int Iscast2)
    { 
    
    
    
    
    }
    
}
