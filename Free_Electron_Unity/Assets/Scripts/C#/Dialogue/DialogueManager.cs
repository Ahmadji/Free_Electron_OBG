using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    // Queue is a FIFO collection (first in first out)
    // Fits well for what we want to do
    private Queue<string> sentences;

    // Start is called before the first frame update
    void Awake()
    {
        // Initialize
        sentences = new Queue<string>();
    }

    public void StartDialogue(Dialogue dialogue)
    {
        Debug.Log("Starting conversation with " + dialogue.name);

        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence(dialogue.textMesh);
    }

    public void DisplayNextSentence(TextMeshPro textMesh)
    {
        if(sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        textMesh.text = sentence;

    }

    private void EndDialogue()
    {
        Debug.Log("End of dialogue");
    }
}
