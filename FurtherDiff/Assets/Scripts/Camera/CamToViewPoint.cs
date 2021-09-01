using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamToViewPoint : MonoBehaviour
{
    public GameObject PivotView;
    public GameObject ViewPointGO;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        SmoothPR();





    }

    private void SmoothPR()
    {
        SmoothMove();

        SmoothStare();
    }

    private void SmoothMove()
    {

        //PivotView.transform.InverseTransformPoint(transform.position) // cameranin viewe gore locali
        //ViewPointGO.transform.localPosition
        //PivotView.transform.TransformPoint() // geri cevirecek localden worlde

        transform.position = ViewPointGO.transform.position;
        
        /*
        var k1 = PivotView.transform.InverseTransformPoint(transform.position);
        var k2 = ViewPointGO.transform.localPosition;
        var k3 = Vector3.Slerp(k1, k2, 1);

        transform.position = PivotView.transform.TransformPoint(k3);
        */
        

    }

    private void SmoothStare()
    {
  
         transform.rotation = ViewPointGO.transform.rotation; //Quaternion.Lerp(transform.rotation, ViewPointGO.transform.rotation, 1);
    }

}
