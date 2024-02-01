using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Item : ScriptableObject
{
    public int Id = 0;
    public string Name = "Item Name";
    public GameObject Model;
    public Sprite Icon;
    public int Price;
}
