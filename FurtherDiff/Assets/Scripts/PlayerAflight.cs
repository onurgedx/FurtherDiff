using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class PlayerAflight :  PlayerPostaci
{



    private void Update()
    {
        
    }




    public override void W()
    {
        animator.SetFloat("time", animator.GetFloat("time") + Time.deltaTime);

        Debug.Log("ww");
    }

    public override void S()
    {
        animator.SetFloat("time", animator.GetFloat("time") - Time.deltaTime);

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
        Debug.Log("space");
    }

    public override void Shift()
    {
        Debug.Log("shift");
    }




}
