using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Collectibale_Item : MonoBehaviour
{
    //[SerializeField] private So_ItemData ItemData;
    [SerializeField] private GameObject tooltip;
    [SerializeField] private Transform transformCamera;
    public GameObject InfoPanel;
    public TMP_Text nameText;
    public TMP_Text descText;







    //private void Update()
    // {
    //if (isInRange)
    // {
    //TooltipAttribute.transform.LookAt(transformCamera);
    // }

    //if (isInRange && Input.GetKeyDown(KeyCode.E))
    //{
    //StartCoroutine(PanelCoroutine());
    //}
    //}


    //IEnumerator PanelCoroutine()
    // {
    //Tooltip.SetActive(false);
    //InfoPanel.SetActive(true);
    //nameText.text = "You have found a '" + Item_Data.itemName + "'.";
    //descText.text = Item_Data.itemDesc;
    //yield return new WaitForSeconds(9);
    //InfoPanel.SetActive(false);

    //}





}
