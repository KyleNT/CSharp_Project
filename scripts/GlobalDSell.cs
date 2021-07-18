using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalDSell : MonoBehaviour
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
    public static float dsellValue = 10f;
    public static bool turnOffButton = false;
    public GameObject DSellStats;
    public static float numberOfDSell;
    public static float DSellPerSec;    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentCash = GlobalCash.CashCount;
        DSellStats.GetComponent<Text>().text = "D. Sell: " + DSellPerSec + " p/sec";
        
        fakeNameText.GetComponent<Text>().text = "Daiyousei";
        fakePriceText.GetComponent<Text>().text = "AL$ " + dsellValue;
        fakeNumber.GetComponent<Text>().text = "" + numberOfDSell;

        realNameText.GetComponent<Text>().text = "Daiyousei";
        realPriceText.GetComponent<Text>().text = "AL$ " + dsellValue;
        realNumber.GetComponent<Text>().text = "" + numberOfDSell;

        if (currentCash >= dsellValue) 
        {
            fakeButton.SetActive(false);
            realButton.SetActive(true);
        }
        if (currentCash < dsellValue) 
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
