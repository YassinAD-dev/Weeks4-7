using UnityEngine;
using UnityEngine.Events;
public class Movingwithkeyboard : MonoBehaviour
{
    public float Speed;
    public UnityEvent onClick;
    public void increaseSpeed()
    {
        Speed += 5f;
    }
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.up * Speed * Time.deltaTime;

        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.down * Speed * Time.deltaTime;

        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * Speed * Time.deltaTime;

        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * Speed * Time.deltaTime;

        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            onClick.Invoke();

        }

    }
}
