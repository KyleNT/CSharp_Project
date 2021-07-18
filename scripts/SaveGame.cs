using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveGame : MonoBehaviour
{

    public float SaveGameCash;
    public static float saveValue = 10f;
    public GameObject SaveButton;
    public GameObject SaveText;

    // Update is called once per frame
    void Update()
    {
        SaveText.GetComponent<Text>().text = "Cost: AL$ " + saveValue;
        SaveGameCash = GlobalCash.CashCount;
        //saveValue = GlobalValueCost.ValueCost;
        if (SaveGameCash >= saveValue) {
            SaveButton.GetComponent<Button>().interactable = true;
        }
        else
        {
            SaveButton.GetComponent<Button>().interactable = false;
        }
    }

    public void SaveTheGame()
    {
        GlobalCash.CashCount -= saveValue;
        //Fumos e Cash
        PlayerPrefs.SetFloat("SavedFumos", GlobalFumos.FumoCount);
        PlayerPrefs.SetFloat("SavedCash", GlobalCash.CashCount);
        //Cirnos
        PlayerPrefs.SetFloat("SavedCirnosNum", GlobalCirno.numberOfCirnos);  
        PlayerPrefs.SetFloat("SavedCirnos", GlobalCirno.CirnoPerSec);
        //Rumias
        PlayerPrefs.SetFloat("SavedRumiaNum", GlobalRumia.numberOfRumias);  
        PlayerPrefs.SetFloat("SavedRumias", GlobalRumia.RumiaPerSec); 
        //NightBugs
        PlayerPrefs.SetFloat("SavedWigglebugNum", GlobalWigglebug.numberOfWigglebugs);  
        PlayerPrefs.SetFloat("SavedWigglebugs", GlobalWigglebug.WigglebugPerSec);              
        //Daiyouseis
        PlayerPrefs.SetFloat("SavedDSells", GlobalDSell.numberOfDSell);
        PlayerPrefs.SetFloat("SavedDSellPerSec", GlobalDSell.DSellPerSec);
        //Koakumas
        PlayerPrefs.SetFloat("SavedKoakumaSells", GlobalKSell.numberOfKSell);
        PlayerPrefs.SetFloat("SavedKSellPerSec", GlobalKSell.KSellPerSec);       
      
        saveValue *= 2f;
        PlayerPrefs.SetFloat("SavedValue", saveValue);

        //Bomba A
        PlayerPrefs.SetFloat("SavedBombA", GlobalCash.bombAValue);

        //Archivements
        
            //FUMO
        //Big Five
        if (GlobalArchievements.ach01Code == 00001) {
            PlayerPrefs.SetInt("SavedAch01", GlobalArchievements.ach01Code);
            //GlobalArchievements.ach01Pan.SetActive(true);
        }

        //101 Fumo
        if (GlobalArchievements.ach02Code == 00002) {
            PlayerPrefs.SetInt("SavedAch02", GlobalArchievements.ach02Code);
            //GlobalArchievements.ach02Pan.SetActive(true);
        }  

            //Cash
        //Little Fifty
        if (GlobalArchievements.ach01_C_Code == 100001) {
            PlayerPrefs.SetInt("SavedAch01_C", GlobalArchievements.ach01_C_Code);
            //GlobalArchievements.ach01_C_Pan.SetActive(true);
        }
        

    }
}
