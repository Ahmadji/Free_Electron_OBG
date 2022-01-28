using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{
    // Queue is a FIFO collection (first in first out)
    // Fits well for what we want to do

    private Queue<string> sentences;

    // Start is called before the first frame update
    void Start()
    {
        // Initialize
        sentences = new Queue<string>();
    }

    public void StartDialogue(Dialogue dialogue)
    {
        Debug.Log("Starting conversation with " + dialogue.name);

        foreach(string sentence in dialogue.sentences)
        {
            Debug.Log(sentence);
        }
    }
}
