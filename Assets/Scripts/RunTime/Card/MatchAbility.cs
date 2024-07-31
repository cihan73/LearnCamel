using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatchAbility : MonoBehaviour
{
    private Card _currentCard;

    private void OnEnable()
    {
        TouchEvents.OnCardTapped += CardTapped_Callback;
        TouchEvents.OnEmptyTapped += EmptyTapped_Callback;
    }
    private void OnDisable()
    {
        TouchEvents.OnCardTapped -= CardTapped_Callback;
        TouchEvents.OnEmptyTapped -= EmptyTapped_Callback;
    }
    private void EmptyTapped_Callback(Card card)
    {
        throw new NotImplementedException();
    }



    private void CardTapped_Callback(Card card)
    {
        _currentCard = card;
        _currentCard.Select();
    }

    private void EmptyTapped_Callback()
    {
        if (_currentCard != null)
        {
            return;
        }
        _currentCard.Deselect();
        _currentCard = null;
    }

}
