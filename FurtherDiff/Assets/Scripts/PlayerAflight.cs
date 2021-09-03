using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class PlayerAflight :  PlayerPostaci
{

    public float speed = 30f;
    public float spinSpeed = 30f;
    

    private void Update()
    {

        Gravity();
        
        

        
    }

    



    public override void WASDatLeastOne()
    {
        //TurnAndGo(speed,1,1,1);

       

    }



    public override void W()
    {
        

          //  setUpViewPoint();


    }




    public override void S()
    {
        //setDownViewPoint();
       
        
    }

    public override void A()
    {
        setLeftViewPoint(10);
    }

    public override void D()
    {
        setRightViewPoint(10);
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
