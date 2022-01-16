using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class puzzleFour : MonoBehaviour
{
    // Start is called before the first frame update
    Image image;
    void Start()
    {
        image = GetComponent<Image>();
        image.enabled = false;
    }

    public void showPicture(){
        image.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}