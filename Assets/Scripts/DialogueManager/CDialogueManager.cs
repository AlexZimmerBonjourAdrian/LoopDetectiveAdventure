using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class CDialogueManager : MonoBehaviour
{
    public Queue<string> sentences;

   public void Start()
    {
        sentences = new Queue<string>();

    }
    public void StartDialogue(CDialogue dialogue)
    {
        Debug.Log("Starting Conversation with " + dialogue.name);
        sentences.Clear();
        
        foreach(string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }
        DisplayNextSentence();
    }
    public void DisplayNextSentence()
    {
        if(sentences.Count == 0)
        {
            EndDialogue();
            return;
        }
        string sentence = sentences.Dequeue();
        Debug.Log(sentence);
    }

    void EndDialogue()
    {
        Debug.Log("End of conversation.");
    }

}
