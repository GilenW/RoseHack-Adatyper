using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nextLevel : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject CanvasGameObject;
    void Start()
    {
        CanvasGameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void showNextLevel(){
        CanvasGameObject.SetActive(true);
    }
}
