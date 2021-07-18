using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalBombA : MonoBehaviour
{
    public GameObject fakeButton;
    public GameObject fakeNameText;
    public GameObject fakePriceText;

    public GameObject realButton;
    public GameObject realNameText;
    public GameObject realPriceText;

    public float currentCash;
    public float Dest;
    //public static float GBA_Value;
    public static bool turnOffButton = false;
   

    // Start is called before the first frame update
/*    void Start()
    {

    }*/

    // Update is called once per frame
    void Update()
    {
        currentCash = GlobalCash.CashCount;
        Dest = GlobalCash.bombAValue;
        

        fakeNameText.GetComponent<Text>().text = "Bomb-A";
        fakePriceText.GetComponent<Text>().text = "AL$ " + GlobalCash.bombAValue;

        realNameText.GetComponent<Text>().text = "Bomb-A";
        realPriceText.GetComponent<Text>().text = "AL$ " + Dest;

        if (currentCash >= GlobalCash.bombAValue) 
        {
            fakeButton.SetActive(false);
            realButton.SetActive(true);
        }
        if (currentCash < GlobalCash.bombAValue) 
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
