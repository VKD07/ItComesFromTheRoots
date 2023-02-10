using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CloudScript : MonoBehaviour
{
    [SerializeField] StatusScript statusScript;
    [SerializeField] float rainWaterValue;
    [Header("Raycast")]
    [SerializeField] float rayCastLength = 2f;
    [SerializeField] Transform rainRay1;
    [SerializeField] Transform rainRay2;
    [SerializeField] Transform rainRay3;
    [SerializeField] LayerMask layerMask;

    RaycastHit hit;

    void Start()
    {
        statusScript = GameObject.Find("StatusSlider").GetComponent<StatusScript>();
    }

    // Update is called once per frame
    void Update()
    {

    

        if(Physics.Raycast(rainRay1.position, -transform.forward, out hit, rayCastLength, layerMask)
            || Physics.Raycast(rainRay2.position, -transform.forward, out hit, rayCastLength, layerMask)
             || Physics.Raycast(rainRay3.position, -transform.forward, out hit, rayCastLength, layerMask)){

            print("IslandHit");

            statusScript.addWater(rainWaterValue);
          

        }

        Debug.DrawRay(rainRay1.position, transform.up, Color.red);
        Debug.DrawRay(rainRay2.position, transform.up, Color.red);
        Debug.DrawRay(rainRay3.position, transform.up, Color.red);
    }
}
