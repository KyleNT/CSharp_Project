using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FatalScript : MonoBehaviour
{

    public GameObject StatusPanel;
    public float fumoCheck;
    public float cashCheck;
    //Fumo
    public int genChanceLost;
    public int genChanceUp;
    //Cash
    public int genChanceLost2;
    public int genChanceUp2; 
    //Fumo  
    public bool disasterActive = false;
    public bool bonusActive = false;
    //Cash
    public bool disasterActive2 = false;
    public bool bonusActive2 = false;
    //Fumo
    public int fumoLoss;
    public int fumoWon;
    //Cash
    public int cashLoss;
    public int cashWon;

    //Tax
    public float tax = 0.05f;

    // Update is called once per frame
    void Update()
    {
        fumoCheck = GlobalFumos.FumoCount / 100; //Na verdade, 100 é um bom número, 35 é para testes.
        cashCheck = GlobalCash.CashCount / 100; //Na verdade, 100 é um bom número, 35 é para testes.

        if (disasterActive == false)
        {
            StartCoroutine(StartDisaster());
        }
        if (bonusActive == false)
        {
            StartCoroutine(StartBonus());
        }
        if (disasterActive2 == false)
        {
            StartCoroutine(StartDisaster2());
        }
        if (bonusActive2 == false)
        {
            StartCoroutine(StartBonus2());
        }       
    }

    IEnumerator StartDisaster()
    {
        disasterActive = true;
        genChanceLost = Random.Range(1, 20);
        if (fumoCheck >= genChanceLost) 
        {
            fumoLoss = Mathf.RoundToInt(GlobalFumos.FumoCount * tax);
            StatusPanel.GetComponent<Text>().text = "You lost " + fumoLoss + " Fumos, by manufacturing defect";
            GlobalFumos.FumoCount -= fumoLoss;
            yield return new WaitForSeconds(3);
            StatusPanel.GetComponent<Animation>().Play("StatusAnim");
            yield return new WaitForSeconds(1);
            StatusPanel.SetActive(false);
            StatusPanel.SetActive(true);
        }
        yield return new WaitForSeconds(10);
        disasterActive = false;
    }

     IEnumerator StartDisaster2()
    {
        disasterActive2 = true;
        genChanceLost2 = Random.Range(1, 20);
        if (cashCheck >= genChanceLost2) 
        {
            cashLoss = Mathf.RoundToInt(GlobalCash.CashCount * tax);
            StatusPanel.GetComponent<Text>().text = "You lost " + cashLoss + " Alice Dollars.";
            GlobalCash.CashCount -= cashLoss;
            yield return new WaitForSeconds(3);
            StatusPanel.GetComponent<Animation>().Play("StatusAnim");
            yield return new WaitForSeconds(1);
            StatusPanel.SetActive(false);
            StatusPanel.SetActive(true);
        }
        yield return new WaitForSeconds(10);
        disasterActive2 = false;
    }   

    IEnumerator StartBonus()
    {
        bonusActive = true;
        genChanceUp = Random.Range(1, 60);
        if (fumoCheck >= genChanceUp) 
        {
            fumoWon = Mathf.RoundToInt(GlobalFumos.FumoCount * tax);
            StatusPanel.GetComponent<Text>().text = "You won " + fumoWon + " Fumos!";
            GlobalFumos.FumoCount += fumoWon;
            yield return new WaitForSeconds(3);
            StatusPanel.GetComponent<Animation>().Play("StatusAnim");
            yield return new WaitForSeconds(1);
            StatusPanel.SetActive(false);
            StatusPanel.SetActive(true);
        }
        yield return new WaitForSeconds(10);
        bonusActive = false;
    }

    IEnumerator StartBonus2()
    {
        bonusActive2 = true;
        genChanceUp2 = Random.Range(1, 60);
        if (cashCheck >= genChanceUp2) 
        {
            cashWon = Mathf.RoundToInt(GlobalCash.CashCount * tax);
            StatusPanel.GetComponent<Text>().text = "You won " + cashWon + " Alice Dollars!";
            GlobalCash.CashCount += cashWon;
            yield return new WaitForSeconds(3);
            StatusPanel.GetComponent<Animation>().Play("StatusAnim");
            yield return new WaitForSeconds(1);
            StatusPanel.SetActive(false);
            StatusPanel.SetActive(true);
        }
        yield return new WaitForSeconds(10);
        bonusActive2 = false;
    }
}
