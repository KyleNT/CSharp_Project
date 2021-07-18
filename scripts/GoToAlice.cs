using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToAlice : MonoBehaviour
{
    public static float A_index;
    public static bool A_bool = true; //Por padrão, ela é a única verdadeira
    public static bool A_a_bool = false; //Restante é falso


    public GameObject Alice;
    public GameObject Reimu;
    public GameObject Marisa;

    public bool Sakamoto = false;

    public GameObject MargatroidFumoButton;
    public GameObject KirisameFumoButton;
    public GameObject ReimuFumoButton;

    public GameObject MargatroidSellButton;
    public GameObject KirisameSellButton;
    public GameObject ReimuSellButton;   

    
    void Start() {
           A_bool = true;
           Sakamoto = A_bool;
      
    }

    public void Margatroid()
    {
        //Alice fica apenas disponível
        A_bool = true;
        A_a_bool = false; //Não pode ser verdadeiro
        A_index = 0f;

        Sakamoto = A_bool;

        //Alice nega o Serviço da Marisa
        GoToMarisa.M_bool = false;
        GoToMarisa.M_a_bool = false;

        //Alice nega o Serviço da Reimu
        GoToReimu.R_bool = false;
        GoToReimu.R_a_bool = false;


        Alice.SetActive(true);
        MargatroidFumoButton.SetActive(true);
        MargatroidSellButton.SetActive(true);

        Marisa.SetActive(false);
        KirisameFumoButton.SetActive(false);
        KirisameSellButton.SetActive(false);

        Reimu.SetActive(false);
        ReimuFumoButton.SetActive(false);
        ReimuSellButton.SetActive(false);

        
    }


}
