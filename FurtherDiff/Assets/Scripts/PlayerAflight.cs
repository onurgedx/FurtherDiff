using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class PlayerAflight :  PlayerPostaci
{

    public float speed = 30f;
    public float spinSpeed = 30f;
    

    public override void Update()
    {

        Gravity();

        base.Update();
        
        

        
    }

    



    public override void WASDatLeastOne()
    {

       

    }



    public override void W()
    {
        

         


    }




    public override void S()
    {
        
       
        
    }

    public override void A()
    {
        
    }

    public override void D()
    {
        
    }

    public override void Space()
    {
        //ResetWheelSpin(4, 90);
        
        OpenGlider();
        //TurnAndGo(speed);
        //Suzul();


    }

    public override void SpaceNO()
    {
        CloseGlider();

        SpinAsWheel(spinSpeed);

        // basedekiler de olsun baska bir sey de olsun diye bu kullanýlabilir !!!
        //base.SpaceNO();

    }

    public override void Shift()
    {

        animator.SetBool("spin", true);
    }

    public override void ShiftNO()
    {
        animator.SetBool("spin", false);

        
    }



}
