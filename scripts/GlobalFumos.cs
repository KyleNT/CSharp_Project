using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalFumos : MonoBehaviour
{
    // Start is called before the first frame update
    /*void Start()
    {
        
    }*/
    public static float FumoCount;

    public GameObject FumoDisplay;
    public GameObject ProdDisplay;
    public GameObject SellDisplay;
    public GameObject GrowingDisplay;
    public GameObject BulkDisplay;

    public float InternalFumo;

    //Cirno
    public static float CirnoSec;

    //Rumia
    public static float RumiaSec;
    public static float int_rmx;

    //Wriggle Nightbug
    public static float WiggleSec;
    public static float int_bgx;   

    //Daiyousei
    public static float DaiyouseiSec;
    
    //Koakuma
    public static float KoakumaSec;
    public static float int_kmx;

    //Total
    public static float TotalProduction;
    public static float TotalSelling;
    public static float TotalSellingST;
    public static float TotalGrow;
    public float TotalBulk;
    public static float TotalBulkRound;


    // Update is called once per frame
    void Update()
    {
        InternalFumo = FumoCount;
        //Cirno
        CirnoSec = GlobalCirno.CirnoPerSec;

        //Rumia
        RumiaSec = GlobalRumia.RumiaPerSec;
        int_rmx = AutoRumia.rumix;

        //Nightbug
        WiggleSec = GlobalWigglebug.WigglebugPerSec;
        int_bgx = AutoWigglebug.bugmix;

        //Daiyousei
        DaiyouseiSec = GlobalDSell.DSellPerSec;

        //Koakuma
        KoakumaSec = GlobalKSell.KSellPerSec;
        int_kmx = AutoKSell.kumix;

        //TotalProduction
        TotalProduction = CirnoSec + (RumiaSec * int_rmx) + (WiggleSec * int_bgx) ;

        //TotalSelling
        TotalSelling = DaiyouseiSec + (KoakumaSec * int_kmx);

        //Growing
        TotalGrow = TotalProduction - TotalSelling;

        //Bulk
        if (TotalProduction == 0f)
        {
           TotalBulk = 1;
           TotalBulkRound = 1;
           TotalSellingST = TotalSelling * 1; 
        }
        if (TotalProduction != 0f) {
            if (TotalSelling == 0f)
            {
                TotalBulk = 1;
                TotalBulkRound = 1;
                TotalSellingST = TotalSelling * 1;
            }
            else {
                TotalBulk = (TotalProduction)/((TotalProduction*100f)/((TotalProduction/(TotalProduction+2f))*5f))+1;
                TotalBulkRound = Mathf.Round(TotalBulk*1f)/1f;
                TotalSellingST = TotalSelling * TotalBulkRound;
            }
        }
        


        FumoDisplay.GetComponent<Text>().text = "" + InternalFumo;

        ProdDisplay.GetComponent<Text>().text = "Create: " + TotalProduction + " p/s";
        SellDisplay.GetComponent<Text>().text = "Sell: " + TotalSellingST + " p/s";
        GrowingDisplay.GetComponent<Text>().text = "Fumos: " + TotalGrow + " p/s";
        BulkDisplay.GetComponent<Text>().text = "Bulk: AL$" + TotalBulkRound + "";

        //First Archie
        GlobalArchievements.ach01Count = InternalFumo;
        //101 Fumo
        GlobalArchievements.ach02Count = InternalFumo;

        
    }
    ///Archivements of Fumos 
    /*
    void OnTriggerEnter()
        {
            //Achievement 1 - Big Five
           
        }*/
}
