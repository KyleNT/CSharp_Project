using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalRumia : MonoBehaviour
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
    public static float rumiaValue = 15f;
    public static bool turnOffButton = false;
    public GameObject RumiaStats;
    public static float numberOfRumias;
    public static float RumiaPerSec;    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentCash = GlobalCash.CashCount;
        RumiaStats.GetComponent<Text>().text = "Rumia: " + RumiaPerSec * AutoRumia.rumix + " p/sec";

        fakeNameText.GetComponent<Text>().text = "Rumia";
        fakePriceText.GetComponent<Text>().text = "AL$ " + rumiaValue;
        fakeNumber.GetComponent<Text>().text = "" + numberOfRumias;

        realNameText.GetComponent<Text>().text = "Rumia";
        realPriceText.GetComponent<Text>().text = "AL$ " + rumiaValue;
        realNumber.GetComponent<Text>().text = "" + numberOfRumias;

        if (currentCash >= rumiaValue) 
        {
            fakeButton.SetActive(false);
            realButton.SetActive(true);
        }
        if (currentCash < rumiaValue) 
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
