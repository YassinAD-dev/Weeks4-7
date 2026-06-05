using UnityEngine;
using TMPro;
public class Texter : MonoBehaviour
{
    public string PlaceHolder ;
    public TextMeshProUGUI name ;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        
    }
    void OnMouseEnter()
    {
        name.text= PlaceHolder ;
    }
    private void OnMouseExit()
    {
        name.text = "not selected" ;
    }
}
