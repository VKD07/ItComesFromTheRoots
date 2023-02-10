using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatusScript : MonoBehaviour
{
    [SerializeField] IslandScript island;
    [SerializeField] Gradient gradient;
    [SerializeField] Image fill;
    [SerializeField] SeasonChanges seasonChanges;

    [Header("Soil Moisture")]
    [SerializeField] public float duringSpringReduction;
    [SerializeField] public float duringSummerReduction;
    [SerializeField] public float duringWinterReduction;
 


    Slider slider;
    void Start()
    {
        slider = GetComponent<Slider>();
        slider.value = island.startingValueStatus;

        fill.color = gradient.Evaluate(1f); 
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        fill.color = gradient.Evaluate(slider.normalizedValue);

        SoilFunction();
    }

    private void SoilFunction()
    {
        //if its spring
        if (seasonChanges.randomSeason == 0)
        {
            print("Spring season");
            slider.value -= duringSpringReduction * Time.deltaTime;

            //if its summer
        }
        else if (seasonChanges.randomSeason == 1)
        {
            print("Summer season");
            slider.value -= duringSummerReduction * Time.deltaTime;
        }

        // if its winter
        else if (seasonChanges.randomSeason == 2)
        {
            print("Winter season");
            slider.value += duringWinterReduction * Time.deltaTime;
        }
    }

    public void addWater(float value)
    {
        slider.value += value * Time.deltaTime;
    }
}
