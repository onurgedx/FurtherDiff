using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class PlayerAflight :  PlayerPostaci
{



    private void Update()
    {
        
    }


    private void OpenGlider()
    {
        animator.SetFloat("time", ClampIt01(animator.GetFloat("time") + 4*Time.deltaTime));


    }

    private void CloseGlider()
    {
        animator.SetFloat("time", ClampIt01(animator.GetFloat("time") -4*Time.deltaTime));

    }

    public override void W()
    {
        
        

        Debug.Log("ww");
    }




    public override void S()
    {
        
        

        Debug.Log("ss");
    }

    public override void A()
    {
        Debug.Log("a");
    }

    public override void D()
    {
        Debug.Log("d");
    }

    public override void Space()
    {

        OpenGlider();



    }

    public override void SpaceNO()
    {
        CloseGlider();

        // basedekiler de olsun baska bir sey de olsun diye bu kullanýlabilir !!!
        //base.SpaceNO();

    }

    public override void Shift()
    {
        Debug.Log("shift");
    }




}
