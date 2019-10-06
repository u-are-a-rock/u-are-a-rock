using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        while (GameController.instance.DirectionalLight.GetComponent<Light>().intensity < 0.7)
        {
           // Debug.Log(GameController.instance.Canvas.GetComponent<CanvasGroup>().alpha);
            yield return new WaitForSeconds(.04f);
            if (GameController.instance.Canvas.GetComponent<CanvasGroup>().alpha > 0)
                GameController.instance.Canvas.GetComponent<CanvasGroup>().alpha -= .025f;
            GameController.instance.DirectionalLight.GetComponent<Light>().intensity += .005f;
        }

        SceneManager.LoadScene("game", LoadSceneMode.Single);
    }

}
