using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOnGround : PlayerPostaci 
{



    public float speed = 30f;
    public float spinSpeed = 10f;
    public float jumpPower = 800f;

    public override void Space()
    {

        Jump(jumpPower);

        
        

    }
    public override void SpaceNO()
    {
        CloseGlider();
    }


    public override void WASDatLeastOne()
    {
        TurnAndGo(speed);

        SpinAsWheel(spinSpeed);

    }
    public override void WASDnot()
    {
        SmoothRotateThenResetWS();
    }

    

    public override void W()
    {
        
        setForwardViewPoint();


        



        //Collision Detection   Continious Spectilative olunca zipliyor karakter giderken !!!



    }



    public override void A()
    {
        setLeftViewPoint();
        
    }
    
    public override void D()
    {
        setRightViewPoint();
        
    }


    public override void S()
    {
        setForwardViewPoint(-1);
        
    }

    


}
