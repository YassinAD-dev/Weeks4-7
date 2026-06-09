using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour
{
    public Image healthbarFillImage;

    public float currentHealth = 100f;
    public float maxHealth = 100f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        healthbarFillImage.fillAmount = currentHealth / maxHealth;
    }
}

