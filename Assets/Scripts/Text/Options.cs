using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Options : MonoBehaviour
{
    public void OptionsButton()
    {
        GameController.instance.MainMenu.SetActive(false);
        GameController.instance.OptionsMenu.SetActive(true);
    }
}
