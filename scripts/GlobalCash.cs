using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalCash : MonoBehaviour
{

    public static float CashCount;
    public static float bombAValue = 10f; //Valor da Compra da Bomba A
    public static float bombA_mlp = 5f; //Multiplicador da Produção e Venda em Bomba A
    public GameObject CashDisplay;
    public float InternalCash;

    // Start is called before the first frame update
    /*void Start()
    {
        
    }*/

    
    // Update is called once per frame
    void Update()
    {
        InternalCash = CashCount;
        CashDisplay.GetComponent<Text>().text = "" + InternalCash;

        //
        GlobalArchievements.ach01_C_Count = InternalCash;
    }
}
