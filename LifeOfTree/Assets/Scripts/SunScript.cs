using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunScript : MonoBehaviour
{
    //Raycast
    [SerializeField] Transform sunRay;
    [SerializeField] float rayDistance;
    [SerializeField] LayerMask layer;
    [SerializeField] float sunHeatValue = 1.5f;

    RaycastHit hit;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = new Ray(sunRay.position, transform.forward);
        if (Physics.Raycast(ray, out hit, rayDistance, layer))
        {
            GameObject hitObject = hit.rigidbody.gameObject;

            if (hitObject.layer == LayerMask.NameToLayer("Island"))
            {
                hitObject.GetComponent<IslandScript>().slider.value -= sunHeatValue * Time.deltaTime;
                print("Sun hit!");
            }
             if (hitObject.layer == LayerMask.NameToLayer("Cloud"))
            {
                print("Cloud hit!");    
            }
        }

        Debug.DrawRay(sunRay.position, transform.forward * rayDistance, Color.red);
    }
}
