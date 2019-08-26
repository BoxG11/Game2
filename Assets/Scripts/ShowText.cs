using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowText : MonoBehaviour
{

    public Transform Shop;
    public Transform Army;
    public Transform Farm;

    public Transform ShopSign;
    public Transform ArmySign;
    public Transform FarmSign;

    public Vector3 Offset;

    // Start is called before the first frame update
    void Start()
    {
        ShopSign.position = Shop.position + Offset;
        ArmySign.position = Army.position + Offset;
        FarmSign.position = Farm.position + Offset;
    }
}
