using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMovementController : MonoBehaviour
{


    private float mouseX;
    private float mouseY;
    public float Sensitivity;
    public float SensitivityX;
    public float SensitivityY;







    // Start is called before the first frame update
    private void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        mouseRefresh();




    }



    public float GetMouseX
    {
        get { return mouseX; }
        
    }
    public float GetMouseY
    {
        get { return mouseY; }
    }



    private void mouseRefresh()
    {
        mouseXRefresh();
        mouseYRefresh();
    }

    private void mouseXRefresh()
    {

      mouseX =  Input.GetAxis("Mouse X") * Time.deltaTime * SensitivityX*Sensitivity;

    }

    private void mouseYRefresh()
    {
        mouseY = Input.GetAxis("Mouse Y") * Time.deltaTime * SensitivityY*Sensitivity;

    }







}
