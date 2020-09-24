using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class panelHide : MonoBehaviour
{
    public GameObject Panel;
    private int counter;
    // Start is called before the first frame update
    void Start()
    {
        Panel.SetActive(false);
    }


    public void showHidePanel()
    {
        counter++;
        if(counter % 2 == 1)
        {
            Panel.gameObject.SetActive(false);
        }
        else
        {
            Panel.gameObject.SetActive(true);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
