using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    

    [SerializeField]
    private GameObject player;

    public Animator animator;

    public GameObject controller;

    private PlayerPostaci Pcomponent;


    public List<string> atLeastOneKey;


    List<string> PressedButtons = new List<string>() ;

    List<string> UnPressedButtons = new List<string>();
    

    // Start is called before the first frame update
    private void Start()
    {

        
        
    }

    // Update is called once per frame
    private void Update()
    {


        CheckControllerSibilings();



    }


    // Childeren icinde bir degisiklik oldugunda bana bildiren bir fonksiyon !!!!!!
    //private void OnTransformChildrenChanged()
   
    private void CheckControllerSibilings()
    {


        //
        CleaningList(PressedButtons); // Listeyi temizliyor 

        CleaningList(UnPressedButtons);//Basilmayanlar listesini temizliyor.
        //




        UnAndPressedListUpdate(); // aktif olanlari PressedButtons listesine ekliyor
                                  // pasif olanlarý UnPressedButtons listesine ekliyor


        LeastOneGivenKey(atLeastOneKey); 



        // EGER iki TUS BASILDIGINDA FARKLI BIR SEY OLSUN ISTIYORSAK
        // ComparePresseds(List<string> listPressed) KULLANIRIZ !!!!
        // ICERI YAZILANLAR AYNI ANDA BASILMIS ISE TRUE DONDURUYOR
        /*
        if(ComparePresseds(new List<string> { "W", "A", "S", "D" }))
        {

        }
        */




        LaunchListed(PressedButtons); // listedekileri calistiriyor
        LaunchListed(UnPressedButtons); // Basilmamislar icin ayri bir fonk gonderiyor


       


    }


    private void LeastOneGivenKey(List<string> listWhole)
    {
        foreach (string listName in listWhole)
        {

            if (IsAnyFromThese(listName))
            {

                AddingToList(listName + "atLeastOne", PressedButtons);



            }
            else
            {
                AddingToList(listName+"not", UnPressedButtons);
            }
        }
    

    }
    

    

    private bool IsAnyFromThese(string listPressed)
    {

       
        foreach (char str in listPressed)
        {
             

            if(PressedButtons.Contains(str.ToString()))
            {
                return true;
            }

            

        }
        return false;


    }


    private bool ComparePresseds(List<string> listPressed)
    {
        foreach (string str in listPressed)
        {
            bool a = PressedButtons.Contains(str);

            if (!a)
            {
                return a;


            }

        }

        return true;


    }



    // bu yorabilir
    private void RefreshPComponent()
    {
        Pcomponent = player.transform.GetChild(0).gameObject.GetComponent<PlayerPostaci>();
       // Debug.Log(Pcomponent.name);
    }
    
    private void LaunchListed( List<string> buttons) 
    {
        RefreshPComponent();


        foreach (string name in buttons)
        {
            LaunchOrder(name);

        }
    }

    private void UnAndPressedListUpdate()
    {
        for (int i = 0; i < controller.transform.childCount; i++)
        {
            string name = controller.transform.GetChild(i).gameObject.name;
            bool isOnline = controller.transform.GetChild(i).gameObject.activeInHierarchy;

            if (isOnline)//if it is active
            {

                AddingToList(name, PressedButtons); // Pressed Button is adding to list named PressedButtons 




            }
            else
            {
                AddingToList(name+"NO", UnPressedButtons); //Unpressed Button is adding to list name UnpressedButtons
                

            }

        }

    }

    private void CleaningList(List<string> list )
    {
        list.Clear();

    }

    private void AddingToList(  string name,List<string> list)
    {
        list.Add(name);
    }

   

   private void LaunchOrder(string name)
    {
       
        
        Pcomponent.Invoke(name,0f);
        
        
        
        

    }

    private void W() 
    {
        //player.transform.GetChild(0).gameObject.GetComponent<PlayerAflight>().Invoke("W",0f);
        
        Debug.Log("w");
        
    }

    private void S()
    {
        
        Debug.Log("ss");
    }

    private void A()
    {
        Debug.Log("a");
    }

    private void D()
    {
        Debug.Log("d");
    }

    private void Space()
    {
        Debug.Log("space");
    }

    private void Shift()
    {
        Debug.Log("shift");
    }


   

}
