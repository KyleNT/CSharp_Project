using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalKSell : MonoBehaviour
{
    public GameObject fakeButton;
    public GameObject fakeNameText;
    public GameObject fakePriceText;
    public GameObject fakeNumber;

    public GameObject realButton;
    public GameObject realNameText;
    public GameObject realPriceText;
    public GameObject realNumber; 

    public float currentCash;
    public static float ksellValue = 20f;
    public static bool turnOffButton = false;
    public GameObject KSellStats;
    public static float numberOfKSell;
    public static float KSellPerSec;    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentCash = GlobalCash.CashCount;
        KSellStats.GetComponent<Text>().text = "K. Sell: " + KSellPerSec * AutoKSell.kumix  + " p/sec";
        
        fakeNameText.GetComponent<Text>().text = "Koakuma";
        fakePriceText.GetComponent<Text>().text = "AL$ " + ksellValue;
        fakeNumber.GetComponent<Text>().text = "" + numberOfKSell;

        realNameText.GetComponent<Text>().text = "Koakuma";
        realPriceText.GetComponent<Text>().text = "AL$ " + ksellValue;
        realNumber.GetComponent<Text>().text = "" + numberOfKSell;

        if (currentCash >= ksellValue) 
        {
            fakeButton.SetActive(false);
            realButton.SetActive(true);
        }
        if (currentCash < ksellValue) 
        {
            fakeButton.SetActive(true);
            realButton.SetActive(false);
        }        
        if (turnOffButton == true)
        {
            realButton.SetActive(false);
            fakeButton.SetActive(true);
            turnOffButton = false;
        }
    }
}
