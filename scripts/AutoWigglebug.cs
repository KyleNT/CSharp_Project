using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoWigglebug : MonoBehaviour //Atenção, Rumia!
{
    public bool CreatingFumo = false;
    public static float FumoIncrease = 3f;
    public static float bugmix = 3f;
    public float InternalIncrease;

    // Start is called before the first frame update
/*    void Start()
        {

        }*/

    // Update is called once per frame
    void Update()
    {
        FumoIncrease = GlobalWigglebug.WigglebugPerSec * bugmix;
        InternalIncrease = FumoIncrease;

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
                        CreatingFumo = true;
                        StartCoroutine(CreateTheFumo1());
                    } 
        }   
    }

    //Padrão Alice
    IEnumerator CreateTheFumo1() 
    {
        GlobalFumos.FumoCount += InternalIncrease;
        yield return new WaitForSeconds(1);
        CreatingFumo = false;           
	}

    //Padrão Reimu
    IEnumerator CreateTheFumo2() 
    {
        GlobalFumos.FumoCount += InternalIncrease * 2f;
        yield return new WaitForSeconds(1);
        CreatingFumo = false;           
	}

    //Padrão Marisa
    IEnumerator CreateTheFumo3() 
    {
        GlobalFumos.FumoCount += InternalIncrease * 3f;
        yield return new WaitForSeconds(1);
        CreatingFumo = false;           
	}
}
