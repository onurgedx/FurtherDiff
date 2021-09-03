using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActs : MonoBehaviour
{
    public Animator animator;
    public Rigidbody rg;
    public GameObject player;
    public GameObject ViewPoint;

    private GameObject Armature;
    private Vector3 viewDirection;

    public float GravityScale = 10;



    // Start is called before the first frame update

    private void Start()
    {
        //there is only one gameobject has this "Player" tag.
        player = GameObject.FindGameObjectWithTag("Player");
        Armature = player.transform.GetChild(0).GetChild(0).gameObject;
        rg = player.GetComponent<Rigidbody>();

        ViewPoint = GameObject.FindGameObjectWithTag("ViewPoint");
        viewDirection = ViewPoint.transform.forward;
    }

    public virtual void GoOnlyForward(float speed = 10f)
    {
        // rg.velocity = player.transform.forward * speed;
        //rg.AddForce(player.transform.forward * speed);
        
        rg.velocity += player.transform.forward * speed;

        rg.velocity.Normalize();

        //rg.velocity ;


        //rg.AddForce(player.transform.forward, ForceMode.Impulse);
    }
    public virtual void Gravity()
    {
        rg.AddRelativeForce(Vector3.up * (-1) * GravityScale,ForceMode.Acceleration);

    }


    public virtual void Jump(float jumpPower)
    {
        rg.AddForce(Vector3.up * jumpPower);
    }



    public virtual void setForwardViewPoint(int a = 1)
    {
        View = a * ViewPoint.transform.forward;


    }

    public virtual void setRightViewPoint(float b = 1)
    {
        View = ViewPoint.transform.right / b;
    }

    public virtual void setLeftViewPoint(float b = 1)
    {
        View = -ViewPoint.transform.right / b;
    }

    public virtual void setUpViewPoint(float b = 1)
    {
        View = ViewPoint.transform.up / b;
    }

    public virtual void setDownViewPoint(float b = 1)
    {
        View = -ViewPoint.transform.up / b;
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
            viewDirection += value;


        }

    }
    public Quaternion ViewQ(int x = 1, int y = 0, int z = 1)
    {
        return Quaternion.LookRotation(Vector3.Scale(View, new Vector3(x, y, z)), Vector3.up);
    }
    public virtual void TurnToView(int x = 1, int y = 0, int z = 1)
    {

        player.transform.rotation = Quaternion.Slerp(player.transform.rotation, ViewQ(x, y, z), Time.deltaTime * 5);


    }


    public virtual void TurnAndGo(float speed, int x = 1, int y = 0, int z = 1)
    {
        TurnToView(x, y, z);
        GoOnlyForward(speed);
    }



    //su anlik scroll ile degil farkli bir sekilde degistirme karari aldým 
    public virtual void Scroll(float ScrollScore = 1f)
    {

        var a = ViewPoint.transform.localPosition.z;
        Debug.Log(a);
        var b = ((a + 20) + ScrollScore) / (20 - 10);
        ViewPoint.transform.localPosition = Vector3.Lerp(Vector3.back * 20, Vector3.back * 10, b);
        // ViewPoint.transform.localPosition = Vector3.ClampMagnitude(ViewPoint.transform.localPosition + new Vector3(0, 0,ScrollScore), 20);



    }


    public virtual bool isVelo()
    {

        return rg.velocity.magnitude > 0.01f;
    }

    public virtual void ResetWheelSpin(float timeScaleRWS = 4, float localRotX = 0f)
    {
        Armature.transform.localRotation = Quaternion.Lerp(Armature.transform.localRotation, Quaternion.Euler(localRotX, 0, 0), Time.deltaTime * timeScaleRWS);

    }

    public virtual void Suzul()
    {
        //Armature.transform.rotation = Quaternion.Lerp(Armature.transform.rotation,Quaternion.LookRotation( -Vector3.up , rg.velocity), Time.deltaTime* 4);


}



    public virtual void SmoothRotateThenResetWS(float timeScaleRWS=4f)
    {
        if(isVelo())
        {
            SpinAsWheel(30f);



        }
        else
        {
            ResetWheelSpin(timeScaleRWS);

        }
    }

    public virtual void SpinAsWheel(float spin=1f)
    {
        float veloMagnitude = rg.velocity.magnitude;
        float rotateAmount =  spin*veloMagnitude*Time.deltaTime ;
        Armature.transform.Rotate(rotateAmount, 0, 0);

    }

    //Animations

    public virtual float ClampIt01(float val)
    {
        // girilen sayiyi 0 ile 1 arasýndan cikmamasýný saglar

        return Mathf.Clamp01(val);

    }
    public virtual void OpenGlider()
    {
        animator.SetFloat("time", ClampIt01(animator.GetFloat("time") + 4 * Time.deltaTime));


    }

    public virtual void CloseGlider()
    {
        animator.SetFloat("time", ClampIt01(animator.GetFloat("time") - 4 * Time.deltaTime));

    }





}
