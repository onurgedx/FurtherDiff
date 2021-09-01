using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{

    [SerializeField]
    private GameObject W, A, S, D, Shift, Space, Mouse0, Mouse1;
   

    // Start is called before the first frame update
    private void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        
        

        setOnlineChilds();
    }


  

    private void setOnlineChilds()
    {

        SetGoAccordingToAxis(KeyCode.W,  W );
        SetGoAccordingToAxis(KeyCode.S , S );
        SetGoAccordingToAxis(KeyCode.A, A);
        SetGoAccordingToAxis(KeyCode.D, D);
        SetGoAccordingToAxis(KeyCode.LeftShift, Shift);
        SetGoAccordingToAxis(KeyCode.Space, Space);
        SetGoAccordingToAxis(KeyCode.Mouse0, Mouse0);//Left click
        SetGoAccordingToAxis(KeyCode.Mouse1, Mouse1);//Right click

        //KeyCode.Mouse0



    }

    private void SetGoAccordingToAxis( KeyCode KCode , GameObject Go )
    {
        bool kDown = Input.GetKeyDown(KCode);
        bool k =Input.GetKey(KCode);
        bool kUp = Input.GetKeyUp(KCode);

        

        if(kDown)
        {
            Go.SetActive(true);
          

        }
        

        if (kUp)
        { 
            Go.SetActive(false);
            

        }








    }



   


}
