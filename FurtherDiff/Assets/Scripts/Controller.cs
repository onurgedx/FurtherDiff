using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{

    [SerializeField]
    private GameObject W, A, S, D, Shift, Space;


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
