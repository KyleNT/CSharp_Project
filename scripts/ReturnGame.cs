using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ReturnGame : MonoBehaviour
{

    public GameObject ArchievPan;
 
    public void Returned()
    {
        GoToArchievements.Hisokami = true;
        GoToArchievements.Oreko = true;
        GoToArchievements.Sakamoto = true;
        GoToArchievements.ShowPan = false;
        
        ArchievPan.SetActive(false);
    }


}
