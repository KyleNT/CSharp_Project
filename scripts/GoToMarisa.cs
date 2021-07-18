using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GoToMarisa : MonoBehaviour
{
    public static float M_index;
    public static bool M_bool = false; //Apenas Marisa é Verdadeiro
    public static bool M_a_bool = false; //Restante é falso
    public static float MarisaFloating = 35f;
    public float PayWallMarisa;


    public GameObject Alice;
    public GameObject Reimu;
    public GameObject Marisa;

    public GameObject MargatroidFumoButton;
    public GameObject KirisameFumoButton;
    public GameObject ReimuFumoButton;

    public GameObject MargatroidSellButton;
    public GameObject KirisameSellButton;
    public GameObject ReimuSellButton;

    public GameObject MarisaKirisame; //Botão da Marisa
    public AudioSource playSound;

    void Update()
    {
        PayWallMarisa = GlobalCash.CashCount;
        
        if(PayWallMarisa >= MarisaFloating) {
            MarisaKirisame.GetComponent<Button>().interactable = true;

        } else {
            MarisaKirisame.GetComponent<Button>().interactable = false;
        }
    }

    public void Kirisame()
    {

            playSound.Play();
            GlobalCash.CashCount -= GoToMarisa.MarisaFloating;

            //Marisa fica apenas disponível
            M_bool = true;
            M_a_bool = false;
            M_index = 3f;

            //Marisa nega o serviço da Reimu
            GoToReimu.R_bool = false;
            GoToReimu.R_a_bool = false;

            //Marisa nega o serviço da Alice
            GoToAlice.A_bool = false;
            GoToAlice.A_a_bool = false;


            Marisa.SetActive(M_bool);
            KirisameFumoButton.SetActive(M_bool);
            KirisameSellButton.SetActive(M_bool);

            Alice.SetActive(M_a_bool);
            MargatroidFumoButton.SetActive(M_a_bool);
            MargatroidSellButton.SetActive(M_a_bool);

            Reimu.SetActive(M_a_bool);
            ReimuFumoButton.SetActive(M_a_bool);
            ReimuSellButton.SetActive(M_a_bool);
            

        
    }


}
