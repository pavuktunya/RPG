using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<Item> Items;
    private void Awake()
    {
        //ControllerManager.Items=Items;
    }
}
[System.Serializable]
public class Item
{
    public int Id;
    public string ABC;
}
