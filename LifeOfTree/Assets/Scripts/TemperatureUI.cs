using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TemperatureUI : MonoBehaviour
{
    [SerializeField] SeasonChanges seasonChanges;
    [SerializeField] Slider slider;
    [SerializeField] Gradient gradient;
    [SerializeField] Image fill;
    [SerializeField] float n;
    [SerializeField] float startingValue;

    //Animation

    [SerializeField] Animator arrowUpAnim;
    [SerializeField] Animator arrowDownAnim;
 

    Animator anim;





    void Start()
    {
        fill.color = gradient.Evaluate(1f);
        slider.value = startingValue;
   
    }

    // Update is called once per frame
    void Update()
    {
        seasons();
        fill.color = gradient.Evaluate(slider.normalizedValue);
    }

    private void seasons()
    {

        if (seasonChanges.randomSeason == 1)
        {
            

            print("Its summer");
            slider.value += n * Time.deltaTime;
            arrowUpAnim.SetBool("Heating", true);
            arrowDownAnim.SetBool("Cold", false);

            //if its summer
        }
        else if (seasonChanges.randomSeason == 2)
        {
           
            slider.value -= n * Time.deltaTime;

            arrowUpAnim.SetBool("Heating", false);
            arrowDownAnim.SetBool("Cold", true);
        }
        else
        {
            arrowUpAnim.SetBool("Heating", false);
            arrowDownAnim.SetBool("Cold", false);

            if(slider.value < startingValue)
            {
                slider.value += n * Time.deltaTime;
            }
            else if( slider.value > startingValue)
            {
                slider.value -= n * Time.deltaTime;
            }
        }

       
       

       
    }

   
}
