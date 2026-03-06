using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class MoneyNumber : MonoBehaviour
{
    [SerializeField] private int baseEarnings = 5;
    [SerializeField] private float totalMoney = 0;
    [SerializeField] private Text moneytext;

    void Start()
    {
        StartCoroutine(NewCoolThing());
    }

    IEnumerator NewCoolThing()
    {
       yield return new WaitForSeconds(2);
        totalMoney += baseEarnings;
        moneytext.GetComponent<Text>().text = moneytext.ToString();
        StartCoroutine(NewCoolThing());
    }


}
