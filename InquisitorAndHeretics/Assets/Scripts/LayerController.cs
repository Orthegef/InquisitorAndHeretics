using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LayerController : MonoBehaviour
{
    [SerializeField] private GameObject house;
    [SerializeField] private GameObject unit;
    //[SerializeField] private GameObject node;
    private GameObject[] builds = new GameObject[24];
    private GameObject[] units = new GameObject[24];
    private ModelController[] modelScript = new ModelController[24];
    private UnitContol[] unitContols = new UnitContol[24];
    void Start()
    {
        int id = 0;

        for(int x=0;x<8;x++)
        {
            for(int y=0; y<3;y++)
            {
                builds[id] = Instantiate(house) as GameObject;
                units[id] = Instantiate(unit) as GameObject;
                builds[id].transform.position = new Vector3((float)(x-3.5), 0, (float)(y-1));
                units[id].transform.position = new Vector3((float)(x - 3.5), 0, (float)(y - 1));
                modelScript[id] = builds[id].GetComponent<ModelController>();
                unitContols[id] = units[id].GetComponent<UnitContol>();
                modelScript[id].NewID(id);
                unitContols[id].NewID(id);

                id++;
            }
        }
        
    }
    public void InitLayer()
    {

    }
    public void GenerateHouse(int kilk)
    {

    }
    public void VisionNightLayer(bool vision)
    {
        for(int i =0;i<24;i++)
        {
            builds[i].SetActive(false);
        }
    }
    public void NewNumbers()
    {
        //test
        for (int i = 0; i < 24; i++) { modelScript[i].NewNumber(i); }
    }
}
