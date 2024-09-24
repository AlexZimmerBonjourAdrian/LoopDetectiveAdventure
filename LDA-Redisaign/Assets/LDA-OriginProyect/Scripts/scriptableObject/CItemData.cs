using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Object",menuName ="Loop:DetectiveAdventure/Item")]
public class CItemData : ScriptableObject
{
    // Start is called before the first frame update

    

  
    public string name;
    [TextArea(2, 2)]
    public string description;
    public int Id;
    public Sprite imageItem;
    public bool Important;
    public bool isActive;


}
