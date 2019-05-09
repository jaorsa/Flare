using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextTyper : MonoBehaviour
{
    public float letterPause = 0.2f;

    string message;
    TextMesh textComp;

    // Use this for initialization
    void Start()
    {
        textComp = GetComponent<TextMesh>();
        message = textComp.text;
        textComp.text = "";
        StartCoroutine(TypeText());
    }

    IEnumerator TypeText()
    {
        foreach (char letter in message.ToCharArray())
        {
            textComp.text += letter;
            yield return 0;
            yield return new WaitForSeconds(letterPause);
        }
    }
}
