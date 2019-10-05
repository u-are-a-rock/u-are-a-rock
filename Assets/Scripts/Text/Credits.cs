using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Credits : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject CreditsMenu;
    public void CreditsButton()
    {
        MainMenu.SetActive(false);
        CreditsMenu.SetActive(true);
    }
}
