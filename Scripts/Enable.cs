using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Enable : MonoBehaviour
{
    public GameObject mitexto;
    GameObject[] pauseObjects;
    // Start is called before the first frame update
    void Start()
    {
        pauseObjects = GameObject.FindGameObjectsWithTag("Texto");
        hidePaused();
    }

    // Update is called once per frame
    void Update()
    {
        showPaused();
    }

    public void showPaused()
    {
        foreach (GameObject g in pauseObjects)
        {
            g.SetActive(true);
        }
    }

    //hides objects with ShowOnPause tag
    public void hidePaused()
    {
        foreach (GameObject g in pauseObjects)
        {
            g.SetActive(false);
        }
    }
}
