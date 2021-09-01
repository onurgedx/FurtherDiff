using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewPoint : MonoBehaviour
{
 

    public MouseMovementController MMC;

    private float MouseY;
    

    // Start is called before the first frame update
    private void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        MouseYEffect();
    }

    private void refreshMouseY()
    {
        MouseY = -MMC.GetMouseY;
    }

    private void RotateAccMouseY()
    { 
        transform.Rotate(MouseY,0,0);

    }

    private void Sigorta()
    {
        transform.rotation = Quaternion.Euler(Vector3.Scale(transform.rotation.eulerAngles , new Vector3(1, 1, 0)));

    }

    private void MouseYEffect()
    {
        refreshMouseY();


        if (ClampIt())
        {
            RotateAccMouseY();
        }


        Sigorta();




    }

    private bool ClampIt(float minDeger=-15,float maxDeger=60)
        
    {

        float rotX = transform.rotation.eulerAngles.x;
        float min = 360 + minDeger;
        bool a = ((( rotX+ MouseY) >=  min) || (rotX + MouseY <= maxDeger));
        
        /*
        if(rotX )
        {
            float minDis = min - rotX;
            float maxDis = -rotX +maxDeger;
            Mathf.Min(minDis , Mathf.Abs(maxDis))


        }*/

        return a;

    }

    

}
