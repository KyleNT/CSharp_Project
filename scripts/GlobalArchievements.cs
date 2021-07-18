using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalArchievements : MonoBehaviour
{
    // Start is called before the first frame update

    // Variáveis Gerais
    public GameObject achNote;
    public AudioSource achSound;
    public GameObject ArchievementPanel;
    public bool achActive = false;
    public GameObject achTitle;
    public GameObject achDesc;
  

            //Achieviment 01 Specifics
        // Imagem
        // Great Text (Nome)
        // Small Text (Descrição)
        // Contador (Quantos precisam)
        // Número Gatilho
        // "Código"?

        //FUMOS
    //BigFive Variables
    public GameObject ach01Image;
    public GameObject ach01Title;
    public GameObject ach01Desc;
    public GameObject ach01Pan;
    public static float ach01Count = GlobalFumos.FumoCount;
    public string ach01TitleContent;
    public string ach01DescContent;
    public static float ach01Trigger = 5f;
    public static int ach01Code = 0;

    //101FUMO Variables
    public GameObject ach02Image;
    public GameObject ach02Title;
    public GameObject ach02Desc;
    public GameObject ach02Pan;
    public static float ach02Count = GlobalFumos.FumoCount;
    public string ach02TitleContent;
    public string ach02DescContent;
    public static float ach02Trigger = 101f;
    public static int ach02Code = 0;

        //CASH
    //Little Fifty Variables
    public GameObject ach01_C_Image;
    public GameObject ach01_C_Title;
    public GameObject ach01_C_Desc;
    public GameObject ach01_C_Pan;
    public static float ach01_C_Count = GlobalCash.CashCount;
    public string ach01_C_TitleContent;
    public string ach01_C_DescContent;
    public static float ach01_C_Trigger = 50f;
    public static int ach01_C_Code = 0;       


    void Start(){
        //Resete tudo
        if (GoToArchievements.Hisokami == false) {
        //Resete, caso for a primeira vez que entra
                //Fumo
            //Big 5
            ach01Code = 0;
            PlayerPrefs.SetInt("Ach01", ach01Code);
            //101 Fumo
            ach02Code = 0;
            PlayerPrefs.SetInt("Ach02", ach02Code);

                //Cash
            //Little Fifty
            ach01_C_Code = 0;
            PlayerPrefs.SetInt("Ach01_C", ach01_C_Code);

        }
    }

    // Update is called once per frame
    void Update()
    {
            //FUMO
        //BigFive Update
        ach01Code = PlayerPrefs.GetInt("Ach01");
        if (ach01Count == ach01Trigger && ach01Code != 00001 || GameLoader.SavedAch01 == 00001)
        {
            StartCoroutine(Trigger01Ach());
        }

        //101FUMO Update
        ach02Code = PlayerPrefs.GetInt("Ach02");
        if (ach02Count >= ach02Trigger && ach02Code != 00002 || GameLoader.SavedAch02 == 00002)
        {
            StartCoroutine(Trigger02Ach());
        }      

            //Cash
        //Little Fifty
        ach01_C_Code = PlayerPrefs.GetInt("Ach01_C");
        if (ach01_C_Count >= ach01_C_Trigger && ach01_C_Code != 100001 || GameLoader.SavedAch01_C == 100001)
        {
            StartCoroutine(Trigger01_C_Ach());
        } 


    }

        //Fumo Triggers
    //BigFive Trigger
    IEnumerator Trigger01Ach()
    {
        if (GameLoader.SavedAch01 != 00001){
            achActive = true;
            ach01Code = 00001;
            ach01TitleContent = "Big Five!";
            ach01DescContent =  "You created 5 Fumos!";
            PlayerPrefs.SetInt("Ach01", ach01Code);
            achSound.Play();
            ArchievementPanel.GetComponent<Animation>().Play("ArchievAnim");
            ach01Image.SetActive(true);
            achTitle.GetComponent<Text>().text = ach01TitleContent;
            achDesc.GetComponent<Text>().text = ach01DescContent;
            achNote.SetActive(true);
            yield return new WaitForSeconds(3);
            achSound.Stop();
            ArchievementPanel.GetComponent<Animation>().Stop("ArchievAnim");

            //Resetar UI
            achNote.SetActive(false);
            ach01Image.SetActive(false);
            achTitle.GetComponent<Text>().text = "";
            achDesc.GetComponent<Text>().text = "";
            achActive = false;

            //Registro
                if (ach01Code == 00001) 
                {
                    ach01Image.SetActive(true);
                    ach01Title.GetComponent<Text>().text = ach01TitleContent;
                    ach01Desc.GetComponent<Text>().text = ach01DescContent;
                    ach01Pan.SetActive(true);
                } else
                {
                    ach01Pan.SetActive(false);
                    ach01Image.SetActive(false);
                    ach01Title.GetComponent<Text>().text = "";
                    ach01Desc.GetComponent<Text>().text = "";
                    achActive = false;          
                }
        } else {
            //Registro
                ach01Code = 00001;
                ach01TitleContent = "Big Five!";
                ach01DescContent =  "You created 5 Fumos!";
                PlayerPrefs.SetInt("Ach01", ach01Code);
                yield return new WaitForSeconds(3);
                if (ach01Code == 00001) 
                {
                    ach01Image.SetActive(true);
                    ach01Title.GetComponent<Text>().text = ach01TitleContent;
                    ach01Desc.GetComponent<Text>().text = ach01DescContent;
                    ach01Pan.SetActive(true);
                } else
                {
                    ach01Pan.SetActive(false);
                    ach01Image.SetActive(false);
                    ach01Title.GetComponent<Text>().text = "";
                    ach01Desc.GetComponent<Text>().text = "";
                    achActive = false;          
                }
        }
    }

    //101FUMO Trigger
    IEnumerator Trigger02Ach()
    {
        if (GameLoader.SavedAch02 != 00002){
            achActive = true;
            ach02Code = 00002;
            ach02TitleContent = "101 SHANGAI!";
            ach02DescContent =  "101 Fumos!";
            PlayerPrefs.SetInt("Ach02", ach02Code);
            achSound.Play();
            ArchievementPanel.GetComponent<Animation>().Play("ArchievAnim");
            ach02Image.SetActive(true);
            achTitle.GetComponent<Text>().text = ach02TitleContent;
            achDesc.GetComponent<Text>().text = ach02DescContent;
            achNote.SetActive(true);
            yield return new WaitForSeconds(3);
            achSound.Stop();
            ArchievementPanel.GetComponent<Animation>().Stop("ArchievAnim");

            //Resetar UI
            achNote.SetActive(false);
            ach02Image.SetActive(false);
            achTitle.GetComponent<Text>().text = "";
            achDesc.GetComponent<Text>().text = "";
            achActive = false;

            //Registro
                if (ach02Code == 00002) 
                {
                    ach02Image.SetActive(true);
                    ach02Title.GetComponent<Text>().text = ach02TitleContent;
                    ach02Desc.GetComponent<Text>().text = ach02DescContent;
                    ach02Pan.SetActive(true);
                } else
                {
                    ach02Pan.SetActive(false);
                    ach02Image.SetActive(false);
                    ach02Title.GetComponent<Text>().text = "";
                    ach02Desc.GetComponent<Text>().text = "";
                    achActive = false;          
                }
        } else {
            //Registro
                ach02Code = 00002;
                ach02TitleContent = "101 SHANGAI!";
                ach02DescContent =  "101 Fumos!";
                PlayerPrefs.SetInt("Ach02", ach02Code);
                yield return new WaitForSeconds(3);
                if (ach01Code == 00002) 
                {
                    ach02Image.SetActive(true);
                    ach02Title.GetComponent<Text>().text = ach02TitleContent;
                    ach02Desc.GetComponent<Text>().text = ach02DescContent;
                    ach02Pan.SetActive(true);
                } else
                {
                    ach02Pan.SetActive(false);
                    ach02Image.SetActive(false);
                    ach02Title.GetComponent<Text>().text = "";
                    ach02Desc.GetComponent<Text>().text = "";
                    achActive = false;          
                }
        }
    }


        //CashTriggers
    //Little Fifty
    IEnumerator Trigger01_C_Ach()
    {
        if (GameLoader.SavedAch01_C != 100001){
            achActive = true;
            ach01_C_Code = 100001;
            ach01_C_TitleContent = "Little Fifty!";
            ach01_C_DescContent =  "AL$ 50 is Good!";
            PlayerPrefs.SetInt("Ach01_C", ach01_C_Code);
            achSound.Play();
            ArchievementPanel.GetComponent<Animation>().Play("ArchievAnim");
            ach01_C_Image.SetActive(true);
            achTitle.GetComponent<Text>().text = ach01_C_TitleContent;
            achDesc.GetComponent<Text>().text = ach01_C_DescContent;
            achNote.SetActive(true);
            yield return new WaitForSeconds(3);
            achSound.Stop();
            ArchievementPanel.GetComponent<Animation>().Stop("ArchievAnim");

            //Resetar UI
            achNote.SetActive(false);
            ach01_C_Image.SetActive(false);
            achTitle.GetComponent<Text>().text = "";
            achDesc.GetComponent<Text>().text = "";
            achActive = false;

            //Registro
                if (ach01_C_Code == 100001) 
                {
                    ach01_C_Image.SetActive(true);
                    ach01_C_Title.GetComponent<Text>().text = ach01_C_TitleContent;
                    ach01_C_Desc.GetComponent<Text>().text = ach01_C_DescContent;
                    ach01_C_Pan.SetActive(true);
                } else
                {
                    ach01_C_Pan.SetActive(false);
                    ach01_C_Image.SetActive(false);
                    ach01_C_Title.GetComponent<Text>().text = "";
                    ach01_C_Desc.GetComponent<Text>().text = "";
                    achActive = false;          
                }
        } else {
            //Registro
                ach01_C_Code = 100001;
                ach01_C_TitleContent = "Little Fifty!";
                ach01_C_DescContent =  "AL$ 50 is Good!";
                PlayerPrefs.SetInt("Ach01_C", ach01_C_Code);
                yield return new WaitForSeconds(3);
                if (ach01_C_Code == 100001) 
                {
                    ach01_C_Image.SetActive(true);
                    ach01_C_Title.GetComponent<Text>().text = ach01_C_TitleContent;
                    ach01_C_Desc.GetComponent<Text>().text = ach01_C_DescContent;
                    ach01_C_Pan.SetActive(true);
                } else
                {
                    ach01_C_Pan.SetActive(false);
                    ach01_C_Image.SetActive(false);
                    ach01_C_Title.GetComponent<Text>().text = "";
                    ach01_C_Desc.GetComponent<Text>().text = "";
                    achActive = false;          
                }
        }
    }    


}
