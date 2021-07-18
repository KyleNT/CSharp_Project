using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AutoDSell : MonoBehaviour
{
    public bool SellingFumo = false;
    public static float CashIncrease = 1f;
    public float InternalIncrease;

    // Start is called before the first frame update
    /*void Start()
        {
            if (GoToArchievements.Sakamoto == false) {
                SellingFumo = false;
            }
        }*/

    // Update is called once per frame
    void Update()
    {
        CashIncrease = GlobalDSell.DSellPerSec;
        InternalIncrease = CashIncrease;

      //GoToAlice
       if (GoToReimu.R_bool == false && GoToMarisa.M_bool == false || GoToAlice.A_bool == true) {
            if (SellingFumo == false)
                    {
                    SellingFumo = true;
                        StartCoroutine(SellTheFumo1());
                    } 
        }

        //GoToReimu    
        if (GoToAlice.A_bool == false && GoToMarisa.M_bool == false || GoToReimu.R_bool == true) {
            if (SellingFumo == false)
                    {
                    SellingFumo = true;
                        StartCoroutine(SellTheFumo2());
                    } 
        }

        //GoToMarisa
        if (GoToAlice.A_bool == false && GoToReimu.R_bool == false || GoToMarisa.M_bool == true) {
            if (SellingFumo == false)
                    {
                    SellingFumo = true;
                        StartCoroutine(SellTheFumo3());
                    } 
        } 

       //GoToAlice - First Time - Default
       if (GoToReimu.R_bool == false && GoToMarisa.M_bool == false && GoToAlice.A_bool == false) {
            if (SellingFumo == false)
                    {
                        SellingFumo = true;
                        StartCoroutine(SellTheFumo1());
                    } 
        }  
        
    }

    //Padrão Alice
    IEnumerator SellTheFumo1() 
    {
        if (GlobalFumos.FumoCount < InternalIncrease) {
            SellingFumo = false;
        } else {
            GlobalCash.CashCount += InternalIncrease * GlobalFumos.TotalBulkRound;
            GlobalFumos.FumoCount -= InternalIncrease;
            yield return new WaitForSeconds(1);
            SellingFumo = false;
        }         
	}

    //Padrão Reimu
    IEnumerator SellTheFumo2() 
    {
        if (GlobalFumos.FumoCount < InternalIncrease) {
            SellingFumo = false;
        } else {
            GlobalCash.CashCount += InternalIncrease * GlobalFumos.TotalBulkRound * 2f;
            GlobalFumos.FumoCount -= InternalIncrease;
            yield return new WaitForSeconds(1);
            SellingFumo = false;
        }              
	}

    //Padrão Marisa
    IEnumerator SellTheFumo3() 
    {
        if (GlobalFumos.FumoCount < InternalIncrease) {
            SellingFumo = false;
        } else {
            GlobalCash.CashCount += InternalIncrease * GlobalFumos.TotalBulkRound * 3f;
            GlobalFumos.FumoCount -= InternalIncrease;
            yield return new WaitForSeconds(1);
            SellingFumo = false;
        }          
	}

}
