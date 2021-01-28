using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class CObject : CGenericObject, Iinteract
{
    [SerializeField]
    private string Texto= " ";
   public void Oninteract()
    {
        Debug.Log(Texto);
    }

     void Start()
    {
        base.Start();
        SpriteRenderer sprit;
        sprit = GetComponent<SpriteRenderer>();
        sprit.sprite = imageItem;
    }
}
