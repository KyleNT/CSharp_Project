using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MarisaSellFumo : MonoBehaviour
{
    // Start is called before the first frame update
   // void Start()
   // {
   //     
   // }

    // Update is called once per frame
    //void Update()
    //{
        
    //}

    public GameObject textbox;
    public GameObject StatusPanel;
    public AudioSource CashOne; // Som de Venda 1
    public AudioSource CashTwo; // Som de Venda 2
    public AudioSource noFumo; // Som de Sem Fumos
    public GameObject ParticlePoints_Click2; // Animação
    public int generateTone;

    public void clickthebutton () {
        generateTone = Random.Range(1, 3);
        if (GlobalFumos.FumoCount <= 0f) {
            noFumo.Play();
            StatusPanel.GetComponent<Text>().text = "Status: No Fumos";
            StatusPanel.GetComponent<Animation>().Play("StatusAnim");
        } else
        {
            if (generateTone == 1)
            {
                CashOne.Play();
            }
             if (generateTone == 2)
             {
                CashTwo.Play();
            }           
            GlobalFumos.FumoCount -= 3f;
            GlobalCash.CashCount += GlobalFumos.TotalBulkRound * 3f;
            OnTrigger2D();
        }
    } //Little check

    public void OnTrigger2D () {
        ParticlePoints_Click2.GetComponent<ParticleSystem>().Play();
        StartCoroutine (StopParticle());
    }

    IEnumerator StopParticle() {
        yield return new WaitForSeconds(1);
        ParticlePoints_Click2.GetComponent<ParticleSystem>().Stop();
    }

}
