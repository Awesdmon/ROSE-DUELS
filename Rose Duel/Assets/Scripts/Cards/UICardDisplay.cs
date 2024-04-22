using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class UICardDisplay : MonoBehaviour
{
    /*
     * This takes a Monster Card Scriptable Object to display its contents onto a Monster Card Prefab
     */
    [Header("References")]
    //The scriptable object that contains the data for the card
    [SerializeField] public Card card;
    [SerializeField] TMP_Text card_name;
    [SerializeField] TMP_Text card_cost;
    [SerializeField] Image card_Image;
    [SerializeField] TMP_Text card_tags;
    [SerializeField] TMP_Text card_attack;
    [SerializeField] TMP_Text card_defense;
    [SerializeField] TMP_Text card_speed;
    [SerializeField] GameEvent displayCardInfo;

    [SerializeField] TMP_Text card_description;
    public void UISendInfo()
    {
        displayCardInfo.Raise(this, card);
    }
    // Start is called before the first frame update
    public void SetStats()
    {
        //If the display has a card name and the scriptable object has a card name,
        //then take the card name and display it

        if (card != null)
        {
            if (card_name != null && card.card_name != null)
            {
                card_name.text = card.card_name;
            }

            //If the display has a card cost and the scriptable object has a card cost,
            //then take the card cost and display it
            if (card_cost != null)
            {
                card_cost.text = card.card_cost.ToString();
            }

            //If the display has a card image and the scriptable object has a card image,
            //then take the card image and display it
            if (card_Image != null && card.card_image != null)
            {
                card_Image.sprite = card.card_image;
            }

            //If the display has a card tag and the scriptable object has a card tag,
            //then take the card tag and display it
            if (card.card_tags != null)
            {
                string tagStr = "";
                for (int i = 0; i < card.card_tags.Length; i++)
                {
                    if (i == 0)
                    {
                        tagStr += card.card_tags[i];
                    }

                    if (i > 0 && card.card_tags[i] != "")
                    {
                        tagStr += " - " + card.card_tags[i];
                    }
                }
                card_tags.text = tagStr;
            }

            //If the display has an attack stat and the scriptable object has an attack stat,
            //then take the attack stat and display it
            if (card_attack != null)
            {
                if (card is Monster_Card monster_Card)
                {
                    card_attack.text = monster_Card.Attack.ToString();
                }
                else if (card is Deck_Leader_Card dl_Card)
                {
                    card_attack.text = dl_Card.Attack.ToString();
                }
            }

            //If the display has a defense stat and the scriptable object has a defense stat,
            //then take the defense stat and display it
            if (card_defense != null)
            {
                if (card is Monster_Card monster_Card)
                {
                    card_defense.text = monster_Card.Defense.ToString();
                }
            }

            //If the display has a speed stat and the scriptable object has a speed stat,
            //then take the speed stat and display it
            if (card_speed != null)
            {
                if (card is Monster_Card monster_Card)
                {
                    card_speed.text = monster_Card.Speed.ToString();
                }
                else if (card is Deck_Leader_Card dl_Card)
                {
                    card_speed.text = dl_Card.Speed.ToString();
                }
            }

            //If the display has a card description and the scriptable object has a card description,
            //then take the card description and display it
            if (card_description != null && card.card_description != null)
            {
                card_description.text = card.card_description;
            }
        }


    }

}
