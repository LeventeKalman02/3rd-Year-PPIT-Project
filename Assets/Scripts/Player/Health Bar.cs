using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;

    //set the maximum amount of health for the healthbar slider
    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        //make sure the slider starts with the correct amount of health
        slider.value = health;
    }

    //function to set the slider to the amount of health that is passed in
    public void SetHealth(int health)
    {
        slider.value = health;
    }


}
