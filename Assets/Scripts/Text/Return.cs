using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Return : MonoBehaviour
{
     public void ReturntoMainMenuButton()
    {
       

        GameController.instance.MainMenu.SetActive(true);

        //Set every other menu to false
        GameController.instance.CreditsMenu.SetActive(false);
        GameController.instance.OptionsMenu.SetActive(false);
    }
}
