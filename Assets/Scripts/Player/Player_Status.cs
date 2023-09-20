using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[System.Serializable]
public class Condition
{
    [HideInInspector]
    public float curValue;
    public float maxValue;
    public float startValue;
    public float regenRate;
    public float decayRate;
    public TextMeshProUGUI text;

    public void Add(float amount)
    {
        curValue = Mathf.Min(curValue + amount, maxValue);
    }

    public void Subtract(float amount)
    {
        curValue = Mathf.Max(curValue - amount, 0.0f);
    }

    public float GetPercentage()
    {
        return curValue;
    }

}
public class Player_Status : MonoBehaviour
{
    public Condition health;
    public Condition offense;
    public Condition defense;
    public Condition critical;
    public Condition gold;
    public Condition experience;

    // Start is called before the first frame update
    void Start()
    {
        health.curValue = health.startValue;
        offense.curValue = offense.startValue;
        defense.curValue = defense.startValue;
        critical.curValue = critical.startValue;
        gold.curValue = gold.startValue;
        experience.curValue = experience.startValue;
    }

    // Update is called once per frame
    void Update()
    {
        health.text.text = health.GetPercentage().ToString();
        offense.text.text = offense.GetPercentage().ToString();
        defense.text.text = defense.GetPercentage().ToString();
        critical.text.text = critical.GetPercentage().ToString();
        gold.text.text = gold.GetPercentage().ToString();
    }
}
