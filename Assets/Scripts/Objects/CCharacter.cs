using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Subtegral.DialogueSystem.DataContainers;

//[SerializeField]
public class CCharacter : CGenericCharacter , Iinteract
{
    
    // Start is called before the first frame update
   [SerializeField]
    private new string nameCharacter= " ";
    [SerializeField]
    private DialogueContainer dialogueContainer;
    [SerializeField]
    private CPlayerData playerData;


    // Update is called once per frame
    public override void Oninteract()
    {
        base.Oninteract();
    }

    public override void ChangeAnimation()
    {
        base.ChangeAnimation();
    }


}
