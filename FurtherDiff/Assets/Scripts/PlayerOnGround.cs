using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOnGround : PlayerPostaci 
{






    public override void Space()
    {

        Jump();

        
        

    }

    public override void W()
    {

        setForwardViewPoint();


        TurnAndGo(30f);
     
       



        //Collision Detection   Continious Spectilative olunca zipliyor karakter giderken !!!



    }



    public override void A()
    {
        setLeftViewPoint();
        TurnAndGo(30f);
    }
    
    public override void D()
    {
        setRightViewPoint();
        TurnAndGo(30f);
    }


    public override void S()
    {
        setForwardViewPoint(-1);
        TurnAndGo(30f);
    }

}
