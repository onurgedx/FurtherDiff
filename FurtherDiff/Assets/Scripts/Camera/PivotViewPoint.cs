using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PivotViewPoint : MonoBehaviour
{
    public MouseMovementController MMC;


    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    void Update()
    {

        
        transform.Rotate(0,MMC.GetMouseX, 0);

        transform.rotation = Quaternion.Euler(Vector3.Scale(transform.rotation.eulerAngles, new Vector3(1, 1, 0)));



    }




}
