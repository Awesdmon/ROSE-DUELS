using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class MonsterCardDisplay : MonoBehaviour
{
    /*
     * This takes a Monster Card Scriptable Object to display its contents onto a Monster Card Prefab
     */

    [SerializeField] Monster_Card card;
    [SerializeField] TMP_Text card_name;
    [SerializeField] TMP_Text card_cost;
    [SerializeField] Image card_Image;
    [SerializeField] TMP_Text card_tags;
    [SerializeField] TMP_Text card_attack;
    [SerializeField] TMP_Text card_defense;
    [SerializeField] TMP_Text card_speed;
    [SerializeField] TMP_Text card_description;
    
    // Start is called before the first frame update
    void Start()
    {
        card_name.text = card.card_name;
        card_cost.text = card.card_cost.ToString();

        if (card.card_image != null)
            card_Image.sprite = card.card_image;

        string tagStr = "";
        for (int i = 0; i < card.card_tags.Length; i++) 
        {
            if (card.card_tags[i] != null)
            {
                tagStr += card.card_tags[i] + " ";
            }
        }
        card_tags.text = tagStr;
        
        
        card_attack.text = card.Attack.ToString();
        card_defense.text = card.Defense.ToString();
        card_speed.text = card.Speed.ToString();
        card_description.text = card.card_description;



    }

}
