using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class IslandScript : MonoBehaviour
{
    [Header("Rotation")]
    [SerializeField] float rotationSpeed = 5f;

    [Header("Status")]
    [SerializeField] public float startingValueStatus;
    [SerializeField] SeasonChanges seasonChanges;
    [SerializeField] public Slider slider;

    [Header("Soil Moisture")]
    [SerializeField] float duringSpringReduction;
    [SerializeField] float duringSummerReduction;
    [SerializeField] float duringWinterReduction;

    [Header("Roots spawn")]
    [SerializeField] GameObject[] roots;
    [SerializeField] TextMeshProUGUI maturityValue;

    [Header("Island ground transition")]
    [SerializeField] GameObject ground;
    [SerializeField] Material [] GroundColors;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        IslandRotation();

        spawnRoots();

        changeGroundColor();
    }

  

    private void IslandRotation()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(-Vector3.up * rotationSpeed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
        }
    }

    private void spawnRoots()
    {
       
        if(int.Parse(maturityValue.text) > 20)
        {
            roots[0].SetActive(true);
            roots[1].SetActive(true);
            roots[2].SetActive(true);
        }

        if (int.Parse(maturityValue.text) > 50)
        {
            roots[3].SetActive(true);
            roots[4].SetActive(true);
            roots[5].SetActive(true);
        }

        if (int.Parse(maturityValue.text) >=  75)
        {
            roots[6].SetActive(true);
            roots[7].SetActive(true);
            roots[8].SetActive(true);
            roots[9].SetActive(true);
        }

        if (int.Parse(maturityValue.text) > 100)
        {
            roots[10].SetActive(true);
            roots[11].SetActive(true);
            roots[12].SetActive(true);
            
        }
    }


    private void changeGroundColor()
    {
      if(slider.value > 87f)
        {
            ground.GetComponent<Renderer>().material = GroundColors[1];
        }

         else if(slider.value < 17)
        {
            ground.GetComponent<Renderer>().material = GroundColors[2];
        }

        else
        {
            ground.GetComponent<Renderer>().material = GroundColors[0];
        }


    }
}
