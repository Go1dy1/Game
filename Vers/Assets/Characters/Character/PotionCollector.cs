using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PotionCollector : MonoBehaviour
{
    public Text CollectedPotions; //Количество собранных монет
    public Text AllCollectablePotions; //Общее количество Potion на уровне
    public static float CollectPotions; //Считаем собранные Potion
    private float AllPotionsStart;  //Считаем все Potion находящиеся на уровне
    public bool checkPotion= false;
    void Awake()
    {
        AllPotionsStart =GameObject.FindGameObjectsWithTag("Potion").Length;

        CollectPotions= 0;

     SetAllCollectablePotions();
     CurrentCollectedPotions();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.gameObject.CompareTag("Potion"))
        {
            return;
        }
        other.gameObject.SetActive(false);

        CollectPotions = CollectPotions + 1;

        AllPotionsStart = AllPotionsStart - 1;

        SetAllCollectablePotions();
        CurrentCollectedPotions();

    }

    public void SetAllCollectablePotions()
{
     AllCollectablePotions.text = AllPotionsStart.ToString();
}
 
public void CurrentCollectedPotions()
{
     CollectedPotions.text = CollectPotions.ToString();
}
}
