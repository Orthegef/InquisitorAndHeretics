using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitContol : MonoBehaviour
{
    [SerializeField] private TextMesh textMesh;
    [SerializeField] private Renderer rQuad;
    //Models
    [SerializeField] private Renderer rPeasant;
    [SerializeField] private Renderer rBanditCaptain;
    [SerializeField] private Renderer rBandit;
    [SerializeField] private Renderer rInqusitor;
    [SerializeField] private Renderer rCleric;
    [SerializeField] private Renderer rCultist;
    [SerializeField] private Renderer rNoble;

    private int ID = 0;

    public void VisionUnit(int type)
    {
        //type "0" = all enabled.false
        rPeasant.enabled = false;
        rBanditCaptain.enabled = false;
        rBandit.enabled = false;
        rInqusitor.enabled = false;
        rCleric.enabled = false;
        rCultist.enabled = false;
        rNoble.enabled = false;

        switch (type)
        {
            case 1: rPeasant.enabled = true; break;
            case 2: rBanditCaptain.enabled = true; break;
            case 3: rBandit.enabled = true; break;
            case 4: rInqusitor.enabled = true; break;
            case 5: rCleric.enabled = true; break;
            case 6: rCultist.enabled = true; break;
            case 7: rNoble.enabled = true; break;
        }
    }
    public void NewNumber(int number)
    {
        textMesh.text = number.ToString();
    }
    public void NewID(int id)
    {
        ID = id;
    }
    private void OnMouseDown()
    {
        Debug.Log("My ID = " + ID.ToString());
    }
    private void OnMouseEnter()
    {
        rQuad.enabled = true;
    }
    private void OnMouseExit()
    {
        rQuad.enabled = false;
    }
}
