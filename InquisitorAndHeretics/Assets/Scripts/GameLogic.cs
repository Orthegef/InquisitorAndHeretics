using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameLogic : MonoBehaviour
{
    [SerializeField] private LayerController layer;
    [SerializeField] private UIScript uiScript;
    [SerializeField] private GameObject menu1;
    [SerializeField] private GameObject menu2;
    [SerializeField] private GameObject menu3;

    void Start()
    {
        
    }
    public void NextTurn()
    {
        //test
        layer.NewNumbers();
        layer.VisionNightLayer(false);
    }
    //menu 1
    public void ButtonStartGame()
    {

    }
    public void ButtonOptions1()
    {
        menu1.SetActive(false);
        menu2.SetActive(true);
    }
    public void ButtonExit()
    {

    }
    //menu 2
    public void ButtonBack2()
    {
        menu2.SetActive(false);
        menu1.SetActive(true);
    }
    public void ButtonNext2()
    {
        menu2.SetActive(false);
        menu3.SetActive(true);
    }
    //menu 3

    //налаштування мови у грі
    public void NumLocalization(int id)
    {
        GameInfo.localization = id;
        uiScript.UpdateLocalization();
    }
}
