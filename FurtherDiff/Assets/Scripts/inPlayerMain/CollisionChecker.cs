using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionChecker : MonoBehaviour
{
    [SerializeField]
    private GameObject AFlight , OnGround;





    private void EnterColl(Collision coll)
    {
        if (coll.gameObject.tag == "Ground")
        {
            SetGround();
        }

    }

    private void StayColl(Collision coll)
    {
        if(coll.gameObject.tag=="Ground")
        {
            //SetGround();
        }

    }
    

    private void ExitColl(Collision coll)
    {
        if (coll.gameObject.tag=="Ground")
        {
            SetFly();

        }

    }

    private bool CheckWhetherItisGround(string tag,string expected)
    {
        return tag == expected;
        
    }

    private void SetFly()
    {   AFlight.SetActive(true);
        OnGround.SetActive(false);
        

    }

    private void SetGround()
    {
        OnGround.SetActive(true);
       AFlight.SetActive(false);

    }


    private void OnCollisionEnter(Collision coll)
    {
        EnterColl(coll);


    }

    private void OnCollisionStay(Collision coll)
    {
        StayColl(coll);


    }


    private void OnCollisionExit(Collision coll)
    {

        ExitColl(coll);


    }



}
