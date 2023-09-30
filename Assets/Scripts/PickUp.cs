using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PickUp : MonoBehaviour
{
    public GameObject errorMessage;
    public GameObject pressE;

    public GameObject hammer;
    public GameObject axe;
    public GameObject shotgun;

    private bool playerInRange = false;

    void Start()
    {
        pressE.SetActive(false);
        errorMessage.SetActive(false);
    }

    void Update()
    {
        if (playerInRange && Input.GetKeyDown(KeyCode.E))
        {
            errorMessage.SetActive(true);
            pressE.SetActive(false);

        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            playerInRange = true;
            pressE.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            playerInRange = false;
            pressE.SetActive(false);
            errorMessage.SetActive(false);
        }
    }
}
