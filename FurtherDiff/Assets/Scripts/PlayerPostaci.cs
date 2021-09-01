using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPostaci : PlayerActs
{

    public Animator animator;

    


    

    public virtual float ClampIt01(float val)
    {
        // girilen sayiyi 0 ile 1 arasýndan cikmamasýný saglar

        return Mathf.Clamp01(val);

    }
    public virtual void Mouse0()
    {
        Debug.Log("Mouse0");



    }
    public virtual void Mouse0NO()
    {

        Debug.Log("Mouse0NO");

    }

    public virtual void Mouse1()
    {



    }
    public virtual void Mouse1NO()
    {



    }

    public virtual void W()
    {

        
        
    }
    public virtual void WNO()
    {

    }

    public virtual void S()
    {
        
    }
    public virtual void SNO()
    {

    }

    public virtual void A()
    {
        
    }
    public virtual void ANO()
    {
        

    }


    public virtual void D()
    {
       
    }
    public virtual void DNO()
    {

    }

    public virtual void Space()
    {
        
    }
    public virtual void SpaceNO()
    {

    }

    public virtual void Shift()
    {
        
    }

    public virtual void ShiftNO()
    {

    }



}
