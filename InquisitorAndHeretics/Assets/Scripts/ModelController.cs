using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelController : MonoBehaviour
{
    private Renderer renderer, quadRender;
    private TextMesh textMesh;
    private int ID = 0;
    [SerializeField] private GameObject text;
    [SerializeField] private GameObject quad;


    public void VisionTrue()
    {

    }
    public void VisionFalse()
    {

    }
    public void NewNumber(int number)
    {
        textMesh.text = number.ToString();
    }
    public void NewID(int id)
    {
        ID = id;
    }
    private void OnMouseEnter()
    {
        quadRender.enabled = true;
    }
    private void OnMouseExit()
    {
        quadRender.enabled = false;
    }
    private void OnMouseDown()
    {
        Debug.Log("My ID = " + ID.ToString());
    }
    //private bool vision = true;
    //private void OnTriggerEnter(Collider other)
    //{
    //    if (renderer != null && vision == false)
    //    {
    //        //об'єкт видимий
    //        renderer.enabled = true;
    //        vision = true;
    //    }
    //}
    //private void OnTriggerExit(Collider other)
    //{
    //    if (renderer != null && vision == true)
    //    {
    //        //об'єкт невидимий
    //        renderer.enabled = false;
    //        vision = false;
    //    }
    //}

    void Start()
    {
        renderer = GetComponent<Renderer>();
        quadRender = quad.GetComponent<Renderer>();
        textMesh = text.GetComponent<TextMesh>();
        quadRender.enabled = false;
    }
}
