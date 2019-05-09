using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public float StartingHealth = 100;
    public float CurrentHealth;
    public Slider HealthSlider;
    

    // Start is called before the first frame update
    void Start()
    {
        CurrentHealth = StartingHealth;
        HealthSlider = GetComponent<Slider>();
        HealthSlider.maxValue = StartingHealth;
        HealthSlider.value = CurrentHealth;
        
    }

    // Update is called once per frame
    void Update()
    {
        CurrentHealth -= 0.01f;
        HealthSlider.value = CurrentHealth;

    }
}
