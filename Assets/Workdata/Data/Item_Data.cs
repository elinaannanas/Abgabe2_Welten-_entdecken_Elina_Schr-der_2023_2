using System.Collections;
using System.Collections.Generic;
using UnityEngine;



    [CreateAssetMenu(fileName = "Item_Data", menuName = "ScriptableObject/new Item_Data")]

    public class Item_Data : ScriptableObject
    {
        public string itemName = "";
        public Sprite itemIcon;
        public int goldValue;
        public string itemDesc;
    }
    

