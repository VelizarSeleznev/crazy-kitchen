using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KitchenObject : MonoBehaviour
{
    [SerializeField] private KitchenObjectSO kitchenObjectSo;

    private ClearCounter clearCounter;

    public KitchenObjectSO GetKitchenObjectSO()
    {
        return kitchenObjectSo;
    }

    public void SetClearCounter(ClearCounter clearCounter)
    {
        this.clearCounter = clearCounter;
    }

    public ClearCounter GetClearCounter()
    {
        return clearCounter;
    }
}
