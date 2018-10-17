using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ClickManager : MonoBehaviour 
{
    [Header("Texts")]
    public Text totalMoney;
    public Text moneyPerSecondText;

    public Text upgradeCost1Text;
    public Text upgradeCost2Text;
    public Text upgradeCost3Text;
    public Text upgradeCost4Text;
    public Text upgradeCost5Text;
    public Text clickUpgradeText;

    [Header("Ints")]
    public int totalMoneyInt;
    public int plusClickAmount;
    public int moneyPerSecond;

    [Header("Upgrade Costs")]
    public int upgradeCost1;
    public int upgradeCost2;
    public int upgradeCost3;
    public int upgradeCost4;
    public int upgradeCost5;
    public int clickUpgradeCost;

    [Header("Upgrade Amounts")]
    public int upgradeAmount1;
    public int upgradeAmount2;
    public int upgradeAmount3;
    public int upgradeAmount4;
    public int upgradeAmount5;


    [Header("Floats")]
    [SerializeField] float currentTime;
    [SerializeField] float time;


    private void Start()
    {
        StartCoroutine(MoneyPerSecond2());

        currentTime = time;

        upgradeCost1Text.text = ("Cost: ") + upgradeCost1 + (" Money").ToString();
        upgradeCost2Text.text = ("Cost: ") + upgradeCost2 + (" Money").ToString();
        upgradeCost3Text.text = ("Cost: ") + upgradeCost3 + (" Money").ToString();
        upgradeCost4Text.text = ("Cost: ") + upgradeCost4 + (" Money").ToString();
        upgradeCost5Text.text = ("Cost: ") + upgradeCost5 + (" Money").ToString();
        clickUpgradeText.text = ("Cost: ") + clickUpgradeCost + (" Money").ToString();
    }

    private void Update()
    {
        //MoneyPerSecond();
    }

    public void ClickMoney()
    {
        totalMoneyInt += plusClickAmount;

        totalMoney.text = totalMoneyInt + (" Money").ToString();
    }

    /*
    public void MoneyPerSecond()
    {
        currentTime -= Time.deltaTime * moneyPerSecond;
        if (currentTime <= 0)
        {
            totalMoneyInt++;
            currentTime = time;

            totalMoney.text = totalMoneyInt + (" Money").ToString();
        }
    }
    */

    public IEnumerator MoneyPerSecond2()
    {
        yield return new WaitForSeconds(1);
        totalMoneyInt += moneyPerSecond;
        totalMoney.text = totalMoneyInt + (" Money").ToString();
        StartCoroutine(MoneyPerSecond2());
    }

    public void Upgrade1()
    {
        if (totalMoneyInt >= upgradeCost1)
        {
            moneyPerSecond += upgradeAmount1;
            totalMoneyInt -= upgradeCost1;

            upgradeCost1 = Mathf.RoundToInt(upgradeCost1 * 1.2f);

            upgradeCost1Text.text = ("Cost: ") + upgradeCost1 + (" Money").ToString();

            totalMoney.text = totalMoneyInt + (" Money").ToString();
            moneyPerSecondText.text = moneyPerSecond + (" Money per second").ToString();
        }
        else
        {
            print("Not enough money");
        }
    }


    public void Upgrade2()
    {
        if (totalMoneyInt >= upgradeCost2)
        {
            moneyPerSecond += upgradeAmount2;
            totalMoneyInt -= upgradeCost2;

            upgradeCost2 = Mathf.RoundToInt(upgradeCost2 * 1.5f);

            upgradeCost2Text.text = ("Cost: ") + upgradeCost2 + (" Money").ToString();

            totalMoney.text = totalMoneyInt + (" Money").ToString();
            moneyPerSecondText.text = moneyPerSecond + (" Money per second").ToString();
        }
        else
        {
            print("Not enough money");
        }
    }

    public void Upgrade3()
    {
        if (totalMoneyInt >= upgradeCost3)
        {
            moneyPerSecond += upgradeAmount3;
            totalMoneyInt -= upgradeCost3;

            upgradeCost3 = Mathf.RoundToInt(upgradeCost3 * 1.8f);

            upgradeCost3Text.text = ("Cost: ") + upgradeCost3 + (" Money").ToString();

            totalMoney.text = totalMoneyInt + (" Money").ToString();
            moneyPerSecondText.text = moneyPerSecond + (" Money per second").ToString();
        }
        else
        {
            print("Not enough money");
        }
    }

    public void Upgrade4()
    {
        if (totalMoneyInt >= upgradeCost4)
        {
            moneyPerSecond += upgradeAmount4;
            totalMoneyInt -= upgradeCost4;

            upgradeCost4 = Mathf.RoundToInt(upgradeCost4 * 2.1f);

            upgradeCost4Text.text = ("Cost: ") + upgradeCost4 + (" Money").ToString();

            totalMoney.text = totalMoneyInt + (" Money").ToString();
            moneyPerSecondText.text = moneyPerSecond + (" Money per second").ToString();
        }
        else
        {
            print("Not enough money");
        }
    }

    public void Upgrade5()
    {
        if (totalMoneyInt >= upgradeCost5)
        {
            moneyPerSecond += upgradeAmount5;
            totalMoneyInt -= upgradeCost5;

            upgradeCost5 = Mathf.RoundToInt(upgradeCost5 * 2.7f);

            upgradeCost5Text.text = ("Cost: ") + upgradeCost5 + (" Money").ToString();

            totalMoney.text = totalMoneyInt + (" Money").ToString();
            moneyPerSecondText.text = moneyPerSecond + (" Money per second").ToString();
        }
        else
        {
            print("Not enough money");
        }
    }

    public void ClickUpgrade()
    {
        if (totalMoneyInt >= clickUpgradeCost)
        {
            plusClickAmount *= 2;
            totalMoneyInt -= clickUpgradeCost;

            clickUpgradeCost = Mathf.RoundToInt(clickUpgradeCost * 3.5f);

            clickUpgradeText.text = ("Cost: ") + clickUpgradeCost + (" Money").ToString();

            totalMoney.text = totalMoneyInt + (" Money").ToString();
        }
        else
        {
            print("Not enough money");
        }
    }
}