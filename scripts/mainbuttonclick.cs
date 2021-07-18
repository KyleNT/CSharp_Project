using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainbuttonclick : MonoBehaviour
{
    // Start is called before the first frame update
void Start()
    {
            GoToAlice.A_bool = true;
            GoToReimu.R_bool = false;
            GoToMarisa.M_bool = false;
    }

    // Update is called once per frame
    //void Update()
    //{
        
    //}

    public GameObject textbox;
    public AudioSource FumoCreate;
    public GameObject ParticlePoints_Click; // Animação

    public void clickthebutton () {
        FumoCreate.Play();
        GlobalFumos.FumoCount += 1f;
        OnTrigger2D();
    } //Little check

        public void OnTrigger2D () {
        ParticlePoints_Click.GetComponent<ParticleSystem>().Play();
        StartCoroutine (StopParticle());
    }

    IEnumerator StopParticle() {
        yield return new WaitForSeconds(1);
        ParticlePoints_Click.GetComponent<ParticleSystem>().Stop();
    }

}
