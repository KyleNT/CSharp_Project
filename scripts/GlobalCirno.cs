using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalCirno : MonoBehaviour
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
    public static float cirnoValue = 10f;
    public static bool turnOffButton = false;
    public GameObject CirnoStats;
    public static float numberOfCirnos;
    public static float CirnoPerSec;



    // Start is called before the first frame update
/*    void Start()
    {

    }*/

    // Update is called once per frame
    void Update()
    {

        currentCash = GlobalCash.CashCount;
        CirnoStats.GetComponent<Text>().text = "Cirno: " + CirnoPerSec + " p/sec";
        fakeNameText.GetComponent<Text>().text = "Cirno";
        fakePriceText.GetComponent<Text>().text = "AL$ " + cirnoValue;
        fakeNumber.GetComponent<Text>().text = "" + numberOfCirnos;
        realNameText.GetComponent<Text>().text = "Cirno";
        realPriceText.GetComponent<Text>().text = "AL$ " + cirnoValue;
        realNumber.GetComponent<Text>().text = "" + numberOfCirnos;
        if (currentCash >= cirnoValue) 
        {
            fakeButton.SetActive(false);
            realButton.SetActive(true);
        }
        if (currentCash < cirnoValue) 
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
