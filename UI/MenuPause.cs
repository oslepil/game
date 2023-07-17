using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuPause : MonoBehaviour
{
    public Button buttonActive;
    public GameObject menu;
    bool active = false;
    void Start()
    {
        buttonActive.onClick.AddListener(Menu);
        menu.gameObject.SetActive(false);
    }

    void Menu()
    {
        if (!active)
        {
            menu.SetActive(true);
            Time.timeScale = 0f;
            active = true;
        }
        else
        {
            menu.gameObject.SetActive(false);
            Time.timeScale = 1f;
            active = false;
        }
    }


}
