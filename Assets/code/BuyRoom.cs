using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BuyRoom : MonoBehaviour
{
    [SerializeField] private int roomAmount = 1;
    [SerializeField] private TextMeshProUGUI roomAmountText;

    public void Buy()
    {
        roomAmount += 1;
        roomAmountText.GetComponent<TextMeshProUGUI>().text = roomAmount.ToString();
    }
}
