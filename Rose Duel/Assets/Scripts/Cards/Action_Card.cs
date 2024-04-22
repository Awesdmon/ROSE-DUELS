using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Action", menuName = "Cards/Action")]
public class Action_Card : Card
{
    //After activating effect, send to discard pile
    private void Start()
    {
        card_tags[0] = "Action";
    }

    public new void ApplyEffect()
    {

    }
}
