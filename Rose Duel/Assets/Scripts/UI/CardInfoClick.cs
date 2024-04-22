using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfoClick : MonoBehaviour
{
    /*
     * 
     */

    [Header("References")]
    [SerializeField] GameObject MonsterCard;
    [SerializeField] GameObject ActionSkillCard;
    [SerializeField] GameObject DeckLeaderCard;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HideCardDisplay()
    {
        MonsterCard.SetActive(false);
        DeckLeaderCard.SetActive(false);
        ActionSkillCard.SetActive(false);
    }
    public void DisplayCardOnUI(Component sender, object data)
    {
        if (data is Card)
        {
            if (data is Monster_Card monster)
            {
                MonsterCard.SetActive(true);
                DeckLeaderCard.SetActive(false);
                ActionSkillCard.SetActive(false);
                MonsterCard.GetComponent<UICardDisplay>().card = monster;
                MonsterCard.GetComponent<UICardDisplay>().SetStats();
            }
            else if (data is Action_Card action)
            {
                ActionSkillCard.SetActive(true);
                MonsterCard.SetActive(false);
                DeckLeaderCard.SetActive(false);
                ActionSkillCard.GetComponent<UICardDisplay>().card = action;
                ActionSkillCard.GetComponent<UICardDisplay>().SetStats();
            }
            else if (data is Skill_Card skill)
            {
                ActionSkillCard.SetActive(true);
                MonsterCard.SetActive(false);
                DeckLeaderCard.SetActive(false);
                ActionSkillCard.GetComponent<UICardDisplay>().card = skill;
                ActionSkillCard.GetComponent<UICardDisplay>().SetStats();
            }
            else if (data is Deck_Leader_Card deck)
            {
                DeckLeaderCard.SetActive(true);
                MonsterCard.SetActive(false);
                ActionSkillCard.SetActive(false);
                DeckLeaderCard.GetComponent<UICardDisplay>().card = deck;
                DeckLeaderCard.GetComponent<UICardDisplay>().SetStats();
            }
        }



    }
}
