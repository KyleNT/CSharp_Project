using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLoader : MonoBehaviour
{
        //Geral Strings
        //Fumos
        public float SavedFumos;
        public float SavedCirnos;
        public float SavedRumias;
        public float SavedWigglebugs;

        //Cash
        public float SavedCash;
        public float SavedDSells;
        public float SavedKSells;

        //Save
        public float SavedValue;

        //Bombs
        //Bomb A
        public float SavedBombA;

        //Sells Per Second
        public float SavedDSellPerSec;
        public float SavedKSellPerSec;

        //Production Per Second
        public float SavedCirnosNum;
        public float SavedRumiasNum;
        public float SavedWigglebugNum;

        //Show Archies
        //Fumo
        public static int SavedAch01;
        public static int SavedAch02;

        //Cash
        public static int SavedAch01_C;

    // Start is called before the first frame update
    void Start()
    {
        if(MainMenuOptions.isLoading == true) 
        {
            //Fumos e Cash
            SavedFumos = PlayerPrefs.GetFloat("SavedFumos");
            GlobalFumos.FumoCount = SavedFumos;
            SavedCash = PlayerPrefs.GetFloat("SavedCash");
            GlobalCash.CashCount = SavedCash;

            //Cirnos e Cirnos por Segundo
            SavedCirnos = PlayerPrefs.GetFloat("SavedCirnos");
            GlobalCirno.CirnoPerSec = SavedCirnos;
            SavedCirnosNum = PlayerPrefs.GetFloat("SavedCirnosNum");
            GlobalCirno.numberOfCirnos = SavedCirnosNum;

            //Rumias e Rumias por Segundo
            SavedRumias = PlayerPrefs.GetFloat("SavedRumias");
            GlobalRumia.RumiaPerSec = SavedRumias;
            SavedRumiasNum = PlayerPrefs.GetFloat("SavedRumiasNum");
            GlobalRumia.numberOfRumias = SavedRumiasNum;

            //Nightbugs e NightBugs por Segundo
            SavedWigglebugs = PlayerPrefs.GetFloat("SavedWigglebugs");
            GlobalWigglebug.WigglebugPerSec = SavedWigglebugs;
            SavedWigglebugNum = PlayerPrefs.GetFloat("SavedWigglebugNum");
            GlobalWigglebug.numberOfWigglebugs = SavedWigglebugNum; 

            //Daiyousei e Daiyousei por Segundo
            SavedDSells = PlayerPrefs.GetFloat("SavedDSells");
            GlobalDSell.numberOfDSell = SavedDSells;
            SavedDSellPerSec = PlayerPrefs.GetFloat("SavedDSellPerSec");
            GlobalDSell.DSellPerSec = SavedDSellPerSec;

            //Koakuma e Koakuma por Segundo
            SavedKSells = PlayerPrefs.GetFloat("SavedKSells");
            GlobalKSell.numberOfKSell = SavedKSells;
            SavedKSellPerSec = PlayerPrefs.GetFloat("SavedKSellPerSec");
            GlobalKSell.KSellPerSec = SavedKSellPerSec;            
 
            //Atenção! SaveValue é um inteiro estático do SaveGame, e não faz parte do GameLoader.
            SavedValue = PlayerPrefs.GetFloat("SavedValue");
            SaveGame.saveValue = SavedValue;  

            //Bomba A
            SavedBombA = PlayerPrefs.GetFloat("SavedBombA");
            GlobalCash.bombAValue = SavedBombA;              

            //Archievements
                //Fumo
            //Big Five
            SavedAch01 = PlayerPrefs.GetInt("SavedAch01");
            GlobalArchievements.ach01Code = SavedAch01;
            //101 Fumo
            SavedAch02 = PlayerPrefs.GetInt("SavedAch02");
            GlobalArchievements.ach02Code = SavedAch02;

                //Cash
            //Little Fifty
            SavedAch01_C = PlayerPrefs.GetInt("SavedAch01_C");
            GlobalArchievements.ach01_C_Code = SavedAch01_C;            


        }
    }

}
