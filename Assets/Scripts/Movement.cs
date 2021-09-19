using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]private Camera _mainCamera;
    
    void Update()
    {
        if (Input.touchCount == 1 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            Debug.Log(Input.GetTouch(0).deltaPosition);
        }

        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log( _mainCamera.ScreenToWorldPoint (Input.mousePosition));
        }
    }
}
