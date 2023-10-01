using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class PickUp : MonoBehaviour
{
    public GameObject errorMessage;
    public GameObject pressE;
    public GameObject noclipText;

    public GameObject hammer;
    public GameObject axe;
    public GameObject shotgun;

    public GameObject topdownCam;
    public GameObject playerCam;
    public GameObject pixelCam;

    public GameObject floor;

    private bool playerInRange = false;

    void Start()
    {
        pressE.SetActive(false);
        errorMessage.SetActive(false);
        noclipText.SetActive(false);
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

            StartCoroutine(sceneNext());
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

    IEnumerator sceneNext()
    {
        yield return new WaitForSeconds(5.0f);

        topdownCam.SetActive(false);
        pixelCam.SetActive(false);
        playerCam.SetActive(true);
        floor.SetActive(false);
        noclipText.SetActive(true);

        yield return new WaitForSeconds(6.0f);

        SceneManager.LoadScene("SampleScene");

    }
}
