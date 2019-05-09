using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextDisplay : MonoBehaviour
{
    private TextMeshPro mytext;


    // Start is called before the first frame update
     IEnumerator Start()
    {
        mytext = gameObject.GetComponent<TextMeshPro>();
        int totalVisibleCharacters = mytext.textInfo.characterCount;
        int counter = 0;
        while (true)
        {
            int visibleCount = counter % (totalVisibleCharacters + 1);
            mytext.maxVisibleCharacters = visibleCount;

            //counter += 1;
        }
    }

}
