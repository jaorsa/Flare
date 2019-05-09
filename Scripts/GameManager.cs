using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public int personas = 4;
    public int comida = 2;
    public int agua = 2;
    public float StartingHealth = 100;
    public float CurrentHealth;
    public Slider HealthSlider;

    public static GameManager instance = null;


    // Use this for initialization
    void Start(){
        if (instance == null)
        {
            instance = this;
            /*CurrentHealth = StartingHealth;
            HealthSlider = GetComponent<Slider>();
            HealthSlider.maxValue = StartingHealth;
            HealthSlider.value = CurrentHealth;*/
        }
        else if (instance != null)
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);

        
    }

    // Update is called once per frame
    void Update(){
    	if(personas == 0){
    		/* falta enviar a la escena de perdiste */
    		SceneManager.LoadScene(0);
    		personas = 4;
    		comida = 2;
    		agua = 2;
    	}

    	/*CurrentHealth -= 0.01f;
        HealthSlider.value = CurrentHealth;*/

    }
}