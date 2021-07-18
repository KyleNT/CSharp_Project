using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoCirno : MonoBehaviour
{
    public static bool CreatingFumo = false;
    public static float FumoIncrease = 1f;
    public static float InternalIncrease;
    public bool Sakamotum = false;
    public bool Sakamotois = false;
    public bool Sakamotes = false;
    public bool Sakamotadro = false;
    public bool Sakamoto = false;


    // Start is called before the first frame update
   /*void Start()
       {
    }*/

    // Update is called once per frame
    void Update()
    {
       FumoIncrease = GlobalCirno.CirnoPerSec;               
       InternalIncrease = FumoIncrease;
       Sakamoto = GoToAlice.A_bool;

       //GoToAlice
       if (GoToReimu.R_bool == false && GoToMarisa.M_bool == false || GoToAlice.A_bool == true) {
            if (CreatingFumo == false)
                    {
                    CreatingFumo = true;
                        StartCoroutine(CreateTheFumo1());
                    } 
        }

        //GoToReimu    
        if (GoToAlice.A_bool == false && GoToMarisa.M_bool == false || GoToReimu.R_bool == true) {
            if (CreatingFumo == false)
                    {
                    CreatingFumo = true;
                        StartCoroutine(CreateTheFumo2());
                    } 
        }

        //GoToMarisa
        if (GoToAlice.A_bool == false && GoToReimu.R_bool == false || GoToMarisa.M_bool == true) {
            if (CreatingFumo == false)
                    {
                    CreatingFumo = true;
                        StartCoroutine(CreateTheFumo3());
                    } 
        } 

       //GoToAlice - First Time - Default
       if (GoToReimu.R_bool == false && GoToMarisa.M_bool == false && GoToAlice.A_bool == false) {
            if (CreatingFumo == false)
                    {
                        Sakamotadro = true;
                        CreatingFumo = true;
                        StartCoroutine(CreateTheFumo1());
                    } 
        }               
  
    }

    //Padrão Alice
    IEnumerator CreateTheFumo1() 
    {
        Sakamotum = true;
        GlobalFumos.FumoCount += InternalIncrease;
        yield return new WaitForSeconds(1);
        CreatingFumo = false;           
	}

    //Padrão Reimu
    IEnumerator CreateTheFumo2() 
    {
        Sakamotois = true;
        GlobalFumos.FumoCount += InternalIncrease * 2f;
        yield return new WaitForSeconds(1);
        CreatingFumo = false;           
	}

    //Padrão Marisa
    IEnumerator CreateTheFumo3() 
    {
        Sakamotes = true;
        GlobalFumos.FumoCount += InternalIncrease * 3f;
        yield return new WaitForSeconds(1);
        CreatingFumo = false;           
	}
                       
   
}
