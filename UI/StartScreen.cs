using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartScreen : MonoBehaviour
{
    public Button button;

    void Start()
    {
        Time.timeScale = 0f;
        button.onClick.AddListener(StartGame);
    }

    private void StartGame()
    {
        Time.timeScale = 1f;
        Destroy(this.gameObject);
    }
}
