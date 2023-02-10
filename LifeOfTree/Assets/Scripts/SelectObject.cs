using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectObject : MonoBehaviour
{
    [SerializeField] LayerMask selectedLayer;
    RaycastHit hit;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        
        if(Physics.Raycast(ray, out hit, 100f, selectedLayer))
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
              
            }
        }

        
      
    }
}
