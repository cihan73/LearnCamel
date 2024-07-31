using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardManager : MonoBehaviour
{
    [SerializeField] CardFactory cardFactory;
    [SerializeField] float cellsize;
    Card[,] _cards;

    private void Awake()
    {
        PrepareCards();
    }
    void PrepareCards()
    {
        for (int x = 0; x <= 5; x++)
        {
            for(int y = 0; y <=5; y++)
            {
                cardFactory.CreateCard(GetWorldPosition(x,y,cellsize));
            }
        }
    }

    Vector3 GetWorldPosition(int x, int y, float cellsize)
    { 
    return new Vector3(x, y,0) * cellsize;
    }
}
