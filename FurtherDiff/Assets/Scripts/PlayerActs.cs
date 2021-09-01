using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActs : MonoBehaviour
{

    public Rigidbody rg;
    public GameObject player;
    public GameObject ViewPoint;


    private Vector3 viewDirection;
    
    // Start is called before the first frame update

    private void Start()
    {
        //there is only one gameobject has this "Player" tag.
        player = GameObject.FindGameObjectWithTag("Player");
        rg = player.GetComponent<Rigidbody>();
        ViewPoint = GameObject.FindGameObjectWithTag("ViewPoint");
        viewDirection = ViewPoint.transform.forward;
    }

    public virtual void GoOnlyForward(float speed =10f)
    {
        rg.velocity = player.transform.forward * speed;
    }

    
    public virtual void Jump()
    {
        rg.AddForce(Vector3.up * 700f);
    }


    public virtual void setForwardViewPoint(int a=1)
    {
        View = a*ViewPoint.transform.forward;


    }
   
    public virtual void setRightViewPoint()
    {
        View = ViewPoint.transform.right;
    }

    public virtual void setLeftViewPoint()
    {
        View = -ViewPoint.transform.right;
    }


    public Vector3 View
    {
        get

        {
            //= ViewPoint.transform.forward +ViewPoint.transform.right;

            return viewDirection;
       // Quaternion a =Quaternion.LookRotation(Vector3.Scale(viewDirection,new Vector3(1,0,1)), Vector3.up) ;
        
       // return a;
        }
        set
        {
            viewDirection.Normalize();
           viewDirection   += value;
            
            
        }

    }
    public Quaternion ViewQ()
    {
        return Quaternion.LookRotation(Vector3.Scale(View, new Vector3(1, 0, 1)), Vector3.up); 
    }
    public virtual void TurnToView()
    {
        
        player.transform.rotation = Quaternion.Slerp(player.transform.rotation,ViewQ(), Time.deltaTime*5);// ;
        
        
    }


    public virtual void TurnAndGo(float speed)
    {
        TurnToView();
        GoOnlyForward(speed);
    }



}
