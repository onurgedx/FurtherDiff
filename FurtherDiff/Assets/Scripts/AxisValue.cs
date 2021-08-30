using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxisValue : MonoBehaviour
{
    
    

    private void OnEnable()
    {
        transform.SetAsFirstSibling();

        
    }

    private void OnDisable()
    {
       
            //transform.SetAsLastSibling();
       // transform.SetSiblingIndex(transform.childCount);
        
        
    }

}
