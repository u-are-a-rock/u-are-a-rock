using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    
    public void StartG()
    {
        StartCoroutine(CoRoutine());
    }
    IEnumerator CoRoutine()
    {
        GameController.instance.Canvas.GetComponent<CanvasGroup>().interactable = false;
      // float alpha = GameController.instance.Canvas.GetComponent<CanvasGroup>().alpha;
        while (GameController.instance.Canvas.GetComponent<CanvasGroup>().alpha > 0)
        {
           // Debug.Log(GameController.instance.Canvas.GetComponent<CanvasGroup>().alpha);
            yield return new WaitForSeconds(.08f);
            GameController.instance.Canvas.GetComponent<CanvasGroup>().alpha -= .1f;
            GameController.instance.DirectionalLight.GetComponent<Light>().intensity += .05f;
        }
       
    }
}
