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
    bool isActive = false;
    [SerializeField ] LayerMask islandLayer;

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

        if(Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.touches[0].position);
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit, islandLayer))
            {
                isActive = !isActive;
            }
        }
    }

  

    private void IslandRotation()
    {
        //mobile version
        if (isActive)
        {
            Touch screenTouch = Input.GetTouch(0);
            if (Input.touchCount == 1)
            {
               
                if(screenTouch.phase == TouchPhase.Moved)
                {
                    transform.Rotate(0f, -screenTouch.deltaPosition.x * rotationSpeed * Time.deltaTime, 0f);
                }
            }

            if(screenTouch.phase == TouchPhase.Ended)
            {
                isActive = false;
            }

        }
        //pc version
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0f, 30f * Time.deltaTime, 0f);
        }else if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0f, -30f * Time.deltaTime, 0f);
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
