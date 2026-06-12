using UnityEngine;
using UnityEngine.LowLevelPhysics;
using UnityEngine.UI;

public class Rotator : MonoBehaviour
{
    public GameObject Triangle;
    public Slider slider;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Triangle.transform.rotation = Quaternion.Euler(0f, 0f, slider.value);
    }
}
