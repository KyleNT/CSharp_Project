using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalValueCost : MonoBehaviour
{
    // Start is called before the first frame update
    /*void Start()
    {
        
    }*/
    public static int ValueCost = 10;
    //public GameObject CashDisplay;
    public int InternalValueCost;


    // Update is called once per frame
    void Update()
    {
        InternalValueCost = ValueCost;
        //CashDisplay.GetComponent<Text>().text = "AL$ " + InternalCash;
    }
}
