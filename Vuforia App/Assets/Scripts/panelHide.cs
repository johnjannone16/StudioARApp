using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class panelHide : MonoBehaviour
{
    public GameObject Panel;
    int counter;
    // Start is called before the first frame update
    private void Start()
    {
        counter = 1;
    }


    public void showHidePanel()
    {
        
        if(swipeDetector.count == 1)
        {
            Panel.SetActive(true);
        }
        else if (swipeDetector.count == 0)
        {
            Panel.SetActive(false);
        }
    }

    public void panelActive()
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
