using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{
    private Localization localization = new Localization();
    //Menu 1
    [SerializeField] private Text textStartGame;
    [SerializeField] private Text textOptions1;
    [SerializeField] private Text textExit;
    //Menu 2
    [SerializeField] private Text textOptions2;
    [SerializeField] private Text textNumPeople;
    [SerializeField] private Text textNumPlayer;
    [SerializeField] private Text textBack2;
    [SerializeField] private Text textNext2;
    //Menu 3
    [SerializeField] private Text textCharacter;
    [SerializeField] private Text textWorldview;
    [SerializeField] private Text textGreed;
    [SerializeField] private Text textForgiveness;
    [SerializeField] private Text textRevenge;
    [SerializeField] private Text textBack3;
    [SerializeField] private Text textNext3;
    public void UpdateLocalization()
    {
        //Menu 1
        textStartGame.text = localization.localization[14, GameInfo.localization];
        textOptions1.text = localization.localization[15, GameInfo.localization];
        textExit.text = localization.localization[16, GameInfo.localization];
        //Menu 2
        textOptions2.text = localization.localization[15, GameInfo.localization];
        textNumPeople.text = localization.localization[8, GameInfo.localization];
        textNumPlayer.text = localization.localization[9, GameInfo.localization];
        textBack2.text = localization.localization[17, GameInfo.localization];
        textNext2.text = localization.localization[18, GameInfo.localization];
        //Menu 3
        textCharacter.text = localization.localization[19, GameInfo.localization]+" "+GameInfo.numPlayer.ToString();
        textWorldview.text = localization.localization[10, GameInfo.localization];
        textGreed.text = localization.localization[11, GameInfo.localization];
        textForgiveness.text = localization.localization[12, GameInfo.localization];
        textRevenge.text = localization.localization[13, GameInfo.localization];
        textBack3.text = localization.localization[17, GameInfo.localization];
        textNext3.text = localization.localization[18, GameInfo.localization];
    }
}
