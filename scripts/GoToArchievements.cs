using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToArchievements : MonoBehaviour
{
    public static bool Hisokami = false; //Hisokami é para os Archievements
    public static bool Oreko = false; //Oreko é para a Production
    public static bool Sakamoto = false; //Sakamoto é para os Sells
    public static bool ShowPan = false;

    public GameObject ArchievPan;

    public void Archievements()
    {
        Hisokami = true;
        Oreko = true;
        Sakamoto = true;
        
        ArchievPan.SetActive(true);
        
    }


}
