using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    [SerializeField] Material color1;
    [SerializeField] Material color2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void changeColor1(){
        GetComponent<MeshRenderer>().material = color1;
    }

    public void changeColor2(){
        GetComponent<MeshRenderer>().material = color2;
    }
}
