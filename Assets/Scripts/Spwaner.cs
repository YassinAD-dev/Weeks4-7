using UnityEngine;
using UnityEngine.InputSystem;

public class Spawner : MonoBehaviour
{
    public GameObject runnerPrefab;
    public Vector3 spawnPosition;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            //Spawn a runner!
            Instantiate(runnerPrefab);

            //Spawn a runner that is a child of this object

            Instantiate(runnerPrefab, transform);

            // specific postion of spawn
          

            Vector3 zeroVector = Vector3.zero;

            //Roatation of zero:

            Quaternion zeroRotation = Quaternion.identity;
            Instantiate(runnerPrefab, spawnPosition, Quaternion.identity);

        }
    }
}