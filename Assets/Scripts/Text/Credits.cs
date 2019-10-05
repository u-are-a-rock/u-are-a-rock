using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Credits : MonoBehaviour
{ 
    public void CreditsButton()
    {
        GameController.instance.MainMenu.SetActive(false);
        GameController.instance.CreditsMenu.SetActive(true);
    }
}
