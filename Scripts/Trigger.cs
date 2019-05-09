using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Trigger : MonoBehaviour
{
    GameObject[] TextObject;

    // Use this for initialization
    void Start()
    {
       
       TextObject = GameObject.FindGameObjectsWithTag("Texto");
        hidePaused();
    }

    // Update is called once per frame
    void Update()
    {


                
    }
    
  

    //shows objects with ShowOnPause tag
    public void showPaused()
    {
        foreach (GameObject g in TextObject)
        {
            g.SetActive(true);
        }
    }

    //hides objects with ShowOnPause tag
    public void hidePaused()
    {
        foreach (GameObject g in TextObject)
        {
            g.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D objeto)
    {
        Destroy(this.gameObject);
        showPaused();
    }

}