using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewPointScrolling : MonoBehaviour
{

    public MouseMovementController MouseKing;


    // Start is called before the first frame update
    private void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        Scrolling();



    }


    private void Scrolling()
    {
        

        transform.localPosition = Vector3.ClampMagnitude(transform.localPosition +new Vector3(0,0, MouseKing.GetScrolling) ,20);  

    }




}
