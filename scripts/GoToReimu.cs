using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GoToReimu : MonoBehaviour
{
    public static float R_index;
    public static bool R_bool = false; //Apenas Reimu é Verdadeiro
    public static bool R_a_bool = false; //Restante é falso
    public static float ReimuFloating = 25f;
    public float PayWallReimu;


    public GameObject Alice;
    public GameObject Reimu;
    public GameObject Marisa;

    public GameObject MargatroidFumoButton;
    public GameObject KirisameFumoButton;
    public GameObject ReimuFumoButton;

    public GameObject MargatroidSellButton;
    public GameObject KirisameSellButton;
    public GameObject ReimuSellButton; 

    public GameObject ReimuHakurei; //Botão da Reimu
    public AudioSource playSound;


    void Update()
    {
        PayWallReimu = GlobalCash.CashCount;
        
       if(PayWallReimu >= ReimuFloating) {   
            ReimuHakurei.GetComponent<Button>().interactable = true;

        } else {
            ReimuHakurei.GetComponent<Button>().interactable = false;
        } 
    } 

    public void Hakurei()
    {

        playSound.Play();
        GlobalCash.CashCount -= GoToReimu.ReimuFloating;
        //Reimu fica apenas disponível
        R_bool = true;
        R_a_bool = false; //Não pode ser verdadeiro
        R_index = 2f;

        //Reimu nega o serviço da Marisa
        GoToMarisa.M_bool = false;
        GoToMarisa.M_a_bool = false;

        //Reimu nega o serviço da Alice
        GoToAlice.A_bool = false;
        GoToAlice.A_a_bool = false;

        Reimu.SetActive(R_bool);
        ReimuFumoButton.SetActive(R_bool);
        ReimuSellButton.SetActive(R_bool);

        Alice.SetActive(R_a_bool);
        MargatroidFumoButton.SetActive(R_a_bool);
        MargatroidSellButton.SetActive(R_a_bool);

        Marisa.SetActive(R_a_bool);
        KirisameFumoButton.SetActive(R_a_bool);
        KirisameSellButton.SetActive(R_a_bool);
        }







}
