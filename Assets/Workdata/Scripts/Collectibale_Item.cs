using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Collectibale_Item : MonoBehaviour
{
    [SerializeField] private Item_Data Item_Data;
    [SerializeField] private GameObject tooltip;
    [SerializeField] private Transform transformCamera;
    public GameObject InfoPanel;
    public TMP_Text nameText;
    public TMP_Text descText;
    private bool isInRange=false;
    
    void Start()
    {
        tooltip.SetActive(false);
        transformCamera = Camera.main.transform;
        InfoPanel.SetActive((false));
    }


    private void Update()
     {
    if (isInRange)
     {
         tooltip.transform.LookAt(transformCamera);
    
     }

    if (isInRange && Input.GetKeyDown(KeyCode.E))
    {
    StartCoroutine(PanelCoroutine());
    }
    }


    IEnumerator PanelCoroutine()
     {
    tooltip.SetActive(false);
    InfoPanel.SetActive(true);
    nameText.text = "You have found a '" + Item_Data.itemName + "'.";
    descText.text = Item_Data.itemDesc;
    yield return new WaitForSeconds(9);
    InfoPanel.SetActive(false);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player entered Pickupzone");
            tooltip.SetActive(true);
            isInRange = true;
           
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player exited Pickupzone");
            tooltip.SetActive(false);
            isInRange = false;
           
        }
    }
}

public static class UIExtentions
{
    public static void HideCanvasGroup(this CanvasGroup canvasGroup)
    {
        //alpha no showing screen
        //interactable cant interact anymore
        //blockRaycast = klick raycast ksnn nicht irgendwo durch
        
        canvasGroup.alpha = 0f; 
        canvasGroup.interactable = false;
        canvasGroup.blocksRaycasts = false;
    }
    
    public static void ShowCanvasGroup(this CanvasGroup canvasGroup)
    {
        //alpha no showing screen
        //interactable cant interact anymore
        //blockRaycast = klich raycast durchgehen
        
        canvasGroup.alpha = 1f;
        canvasGroup.interactable = true;
        canvasGroup.blocksRaycasts = true;
    }

    
}


