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

    private Vector3 finalV= Vector3.zero;


    // Start is called before the first frame update

    public virtual void Start()
    {
        //there is only one gameobject has this "Player" tag.
        player = GameObject.FindGameObjectWithTag("Player");
        Armature = player.transform.GetChild(0).GetChild(0).gameObject;
        rg = player.GetComponent<Rigidbody>();

        ViewPoint = GameObject.FindGameObjectWithTag("ViewPoint");
        viewDirection = ViewPoint.transform.forward;

        Debug.Log("sss");
    }

    

    public virtual void Update()
    {
        ApplyFinalVector();


    }

    public virtual void OnEnable()
    {


    }

    private void ApplyFinalVector()
    {
        rg.velocity = FinalVector;
        

    }



    public Vector3 FinalVector
    {
        get
        {
            return finalV;

        }

        set
        {
            finalV = value;
          //   Vector3.ClampMagnitude(finalV, 440);
        }

    }



    public virtual void GoOnlyForward(float speed = 10f)
    {


        
    }
    public virtual void Gravity()
    {

        FinalVector += -Vector3.up*10*Time.deltaTime;

    }


    public virtual void Jump(float jumpPower)
    {
        FinalVector += Vector3.up * jumpPower;
    }



    public virtual void setForwardViewPoint(int a = 1)
    {
        View = a * ViewPoint.transform.forward;


    }

    public virtual void setRightViewPoint()
    {
        View = ViewPoint.transform.right ;
    }

    public virtual void setLeftViewPoint()
    {
        View = -ViewPoint.transform.right;
    }

    public virtual void setUpViewPoint()
    {
        View = ViewPoint.transform.up;
    }

    public virtual void setDownViewPoint()
    {
        View = -ViewPoint.transform.up;
    }


    public Vector3 View
    {
        get

        {
            
            return viewDirection;
            
        }
        set
        {
            viewDirection.Normalize();
            viewDirection += value;


        }

    }
    public Quaternion ViewQ()
    {
        return Quaternion.LookRotation(Vector3.Scale(View, new Vector3(1, 0, 1)), Vector3.up);
    }
    public virtual void TurnToView()
    {

        player.transform.rotation = Quaternion.Slerp(player.transform.rotation, ViewQ(), Time.deltaTime * 5);


    }


    public virtual void TurnAndGo(float speed)
    {
        TurnToView();
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

        return FinalVector.magnitude > 0.01f;
    }

    public virtual void ResetWheelSpin(float timeScaleRWS = 4)
    {
        Armature.transform.localRotation = Quaternion.Lerp(Armature.transform.localRotation, Quaternion.Euler(0, 0, 0), Time.deltaTime * timeScaleRWS);

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
        
        float rotateAmount =  spin* FinalVector.magnitude * Time.deltaTime ;
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
