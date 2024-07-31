using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardFactory : MonoBehaviour
{
    [SerializeField] Card cardPrefab;
    [SerializeField] Transform cardParent;

    public Card CreateCard()
    {
        var card = Instantiate(cardPrefab, cardParent);
        return null;
    }
}
