using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PurchaseLog : MonoBehaviour
{
    public float CashCollected; //Para a Bombas
    public GameObject AutoCirno; //Cirno Production
    public GameObject AutoRumia; //Rumia Prodution
    public GameObject AutoWigglebug; //NightBug Prodution
    public GameObject AutoDSell; //Daiyousei Sell
    public GameObject AutoKSell; //Koakuma Sell

    public GameObject GameUI_BA; //Efeito de Chacoalhão

    public GameObject BombA_Panels; //Animação da Bomba A
    public GameObject BombA_Back;   //Fundo Escuro
    public GameObject BombA_FA1;    //Retângulo Horizontal
    public GameObject BombA_FA2;    //Retângulo Vertical
    public GameObject BombA_Marg;   //Margatroid
    public GameObject BombA_BackBomb; //Fundo do Texto da Bomba A
    public GameObject BombA_Text;   //Texto da Bomba A
    public GameObject BombA_Alice;  //Central Alice
    public GameObject BombA_Beam_Red;   //Feixe Vermelho
    public GameObject BombA_Beam_Blue;  //Feixe Azul
    public GameObject BombA_Beam_Yellow;    //Feixe Amarelo

    public GameObject BombAButton;   //Botão da Bomba A

    public GameObject ParticlePoints_1; // Animação de Produção
    public GameObject ParticlePoints_2; // Animação de Venda
    public AudioSource playSound;
    public AudioSource playSound2;


 

    // Disponibilidade dos Gatilhos
    /*void Update()
    {
	//Disponibilidade da Bomba A
        CashCollected = GlobalCash.CashCount;
        if (CashCollected >= GlobalCash.bombAValue) {
            BombAButton.GetComponent<Button>().interactable = true;
        }
        else
        {
            BombAButton.GetComponent<Button>().interactable = false;
        }

    }*/




    public void StartAutoCirno() //Cirno
    {
        playSound.Play();
        AutoCirno.SetActive(true);
        GoToAlice.A_bool = true; //Ativado por Padrão
        //Cirnos
            GlobalCash.CashCount -= GlobalCirno.cirnoValue;
            //Animação das Partículas
            OnTrigger2D1();

         //Produção da Cirno
            GlobalCirno.cirnoValue *= 2f;
            GlobalCirno.turnOffButton = true;
            GlobalCirno.CirnoPerSec += 1f;
            GlobalCirno.numberOfCirnos += 1f;

    }

    public void StartAutoRumia() //Rumia
    {
        playSound.Play();
        AutoRumia.SetActive(true);
        GoToAlice.A_bool = true; //Ativado por Padrão
        OnTrigger2D1();

        //Rumias
            GlobalCash.CashCount -= GlobalRumia.rumiaValue;
      

        //Produção da Rumia
           GlobalRumia.rumiaValue *= 3f;
           GlobalRumia.turnOffButton = true;
           GlobalRumia.RumiaPerSec += 1f;
           GlobalRumia.numberOfRumias += 1f;
    }

    public void StartAutoWigglebug() //Wigglebug
    {
        playSound.Play();
        AutoWigglebug.SetActive(true);
        GoToAlice.A_bool = true; //Ativado por Padrão
        OnTrigger2D1();

        //Wigglebugs
            GlobalCash.CashCount -= GlobalWigglebug.wigglebugValue;
      

        //Produção da Wigglebug
           GlobalWigglebug.wigglebugValue *= 4f;
           GlobalWigglebug.turnOffButton = true;
           GlobalWigglebug.WigglebugPerSec += 1f;
           GlobalWigglebug.numberOfWigglebugs += 1f;
    }        


   public void StartAutoDSell() //Daiyousei Sell
    {
        playSound.Play();
        AutoDSell.SetActive(true);
        GoToAlice.A_bool = true; //Ativado por Padrão

        //Vendas
        GlobalCash.CashCount -= GlobalDSell.dsellValue;
        OnTrigger2D2();

        //Venda Padrão
        GlobalDSell.dsellValue *= 2f;
        GlobalDSell.turnOffButton = true;
        GlobalDSell.DSellPerSec += 1f;
        GlobalDSell.numberOfDSell += 1f;
    }

    public void StartAutoKSell()
    {
        playSound.Play();
        AutoKSell.SetActive(true);
        GoToAlice.A_bool = true; //Ativado por Padrão
        OnTrigger2D2();

        //Vendas
        GlobalCash.CashCount -= GlobalKSell.ksellValue;

        //Venda Padrão
        GlobalKSell.ksellValue *= 3f;
        GlobalKSell.turnOffButton = true;
        GlobalKSell.KSellPerSec += 1f;
        GlobalKSell.numberOfKSell += 1f;
    }

    // Gatilho da Bomba A
    public void StartBomb_A()
    {
        playSound2.Play();
        BombA_Panels.SetActive(true);
        StartCoroutine(OnTriggerBMA());

        //Custo
        GlobalCash.CashCount -= GlobalCash.bombAValue;

        //Após compra da bomba, dobre o valor
        GlobalCash.bombAValue *= 2f;
        GlobalBombA.turnOffButton = true;

    }

    // Animações de Bombas
    //Bomba A
    IEnumerator OnTriggerBMA () {
        GameUI_BA.GetComponent<Animation>().Play("GameUI_BombA");
        BombA_Back.GetComponent<Animation>().Play("Barr_4");
        BombA_Alice.GetComponent<Animation>().Play("Barr_AL_1");
        BombA_Beam_Red.GetComponent<Animation>().Play("Barr_beam_red");
        BombA_Beam_Blue.GetComponent<Animation>().Play("Barr_beam_blue");
        BombA_Beam_Yellow.GetComponent<Animation>().Play("Barr_beam_yellow");
        BombA_FA1.GetComponent<Animation>().Play("Barr_1");
        BombA_FA2.GetComponent<Animation>().Play("Barr_2");
        BombA_Marg.GetComponent<Animation>().Play("Barr_3");
        BombA_BackBomb.GetComponent<Animation>().Play("Barr_5");
        BombA_Text.GetComponent<Animation>().Play("Barr_6");

            //Multiplicadores

        //Cirno
            GlobalCirno.CirnoPerSec *= GlobalCash.bombA_mlp;
            GlobalCirno.numberOfCirnos *= GlobalCash.bombA_mlp;

        //Rumia
            GlobalRumia.RumiaPerSec *= GlobalCash.bombA_mlp;
            GlobalRumia.numberOfRumias *= GlobalCash.bombA_mlp;

        //WiggleBug
            GlobalWigglebug.WigglebugPerSec *= GlobalCash.bombA_mlp;
            GlobalWigglebug.numberOfWigglebugs *= GlobalCash.bombA_mlp;	

        //Daiyousei
            GlobalDSell.DSellPerSec *= GlobalCash.bombA_mlp;
            GlobalDSell.numberOfDSell *= GlobalCash.bombA_mlp;

        //Koakuma
            GlobalKSell.KSellPerSec *= GlobalCash.bombA_mlp;
            GlobalKSell.numberOfKSell *= GlobalCash.bombA_mlp;

        //Espere até a animação acabar
        yield return new WaitForSeconds(6);

        playSound2.Stop();
        GameUI_BA.GetComponent<Animation>().Stop("GameUI_BombA");
        BombA_Back.GetComponent<Animation>().Stop("Barr_4");
        BombA_Alice.GetComponent<Animation>().Stop("Barr_AL_1");
        BombA_Beam_Red.GetComponent<Animation>().Stop("Barr_beam_red");
        BombA_Beam_Blue.GetComponent<Animation>().Stop("Barr_beam_blue");
        BombA_Beam_Yellow.GetComponent<Animation>().Stop("Barr_beam_yellow");       
        BombA_FA1.GetComponent<Animation>().Stop("Barr_1");
        BombA_FA2.GetComponent<Animation>().Stop("Barr_2");
        BombA_Marg.GetComponent<Animation>().Stop("Barr_3");
        BombA_BackBomb.GetComponent<Animation>().Stop("Barr_5");
        BombA_Text.GetComponent<Animation>().Stop("Barr_6");
        BombA_Panels.SetActive(false);

        //Cirno
            GlobalCirno.CirnoPerSec /= GlobalCash.bombA_mlp;
            GlobalCirno.numberOfCirnos /= GlobalCash.bombA_mlp;

        //Rumia
            GlobalRumia.RumiaPerSec /= GlobalCash.bombA_mlp;
            GlobalRumia.numberOfRumias /= GlobalCash.bombA_mlp;

        //WiggleBug
            GlobalWigglebug.WigglebugPerSec /= GlobalCash.bombA_mlp;
            GlobalWigglebug.numberOfWigglebugs /= GlobalCash.bombA_mlp;	

        //Daiyousei
            GlobalDSell.DSellPerSec /= GlobalCash.bombA_mlp;
            GlobalDSell.numberOfDSell /= GlobalCash.bombA_mlp;

        //Koakuma
            GlobalKSell.KSellPerSec /= GlobalCash.bombA_mlp;
            GlobalKSell.numberOfKSell /= GlobalCash.bombA_mlp;
    }

    //Animações de Partículas
    //Partículas de Compras
    public void OnTrigger2D1 () {
        ParticlePoints_1.GetComponent<ParticleSystem>().Play();
        StartCoroutine (StopParticle1());
    }

    IEnumerator StopParticle1() {
        yield return new WaitForSeconds(3);
        ParticlePoints_1.GetComponent<ParticleSystem>().Stop();
    }

    //Partículas de Venda
    public void OnTrigger2D2 () {
        ParticlePoints_2.GetComponent<ParticleSystem>().Play();
        StartCoroutine (StopParticle2());
    }

    IEnumerator StopParticle2() {
        yield return new WaitForSeconds(3);
        ParticlePoints_2.GetComponent<ParticleSystem>().Stop();
    }


    // Start is called before the first frame update
    /*void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }*/
}
