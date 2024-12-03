using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public void OnMouseDown()
    {
        Destroy(gameObject, 2.0f);
    }
}
