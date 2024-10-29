using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    [SerializeField] private List<Item_Data> itemDatas = new List<Item_Data>();
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Das Erste Element ist:" + itemDatas[0].itemName);

        Debug.Log("Es sind" + itemDatas.Count + "Elemente in der Liste");

        for (int i = 0; i < itemDatas.Count; i++)
        {
            Debug.Log(" Das Item "  + itemDatas[i].itemName + " kostet " + itemDatas[i].goldValue);
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
