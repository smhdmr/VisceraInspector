using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class InputManager : MonoBehaviour
{
    private Ray ray;
    private RaycastHit hitInfo;
    public LayerMask clickLayerMask;

    public Text descriptionText;
           
        
    void Update()
    {        
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if(Input.GetMouseButtonDown(0) && Physics.Raycast(ray, out hitInfo, 100f, clickLayerMask))
        {
            VisceraPart selectedVisceraPart = hitInfo.transform.GetComponent<VisceraPart>();
            descriptionText.fontSize = selectedVisceraPart.textSize;
            descriptionText.text = selectedVisceraPart.descriptionText;
        }

    }

}
