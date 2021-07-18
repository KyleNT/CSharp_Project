using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalWigglebug : MonoBehaviour
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
    public static float wigglebugValue = 25f;
    public static bool turnOffButton = false;
    public GameObject WigglebugStats;
    public static float numberOfWigglebugs;
    public static float WigglebugPerSec;    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentCash = GlobalCash.CashCount;
        WigglebugStats.GetComponent<Text>().text = "Nightbug: " + WigglebugPerSec * AutoWigglebug.bugmix + " p/sec";

        fakeNameText.GetComponent<Text>().text = "Nightbug";
        fakePriceText.GetComponent<Text>().text = "AL$ " + wigglebugValue;
        fakeNumber.GetComponent<Text>().text = "" + numberOfWigglebugs;

        realNameText.GetComponent<Text>().text = "Nightbug";
        realPriceText.GetComponent<Text>().text = "AL$ " + wigglebugValue;
        realNumber.GetComponent<Text>().text = "" + numberOfWigglebugs;

        if (currentCash >= wigglebugValue) 
        {
            fakeButton.SetActive(false);
            realButton.SetActive(true);
        }
        if (currentCash < wigglebugValue) 
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
