using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    public Transform context;
    public void Prepare(/*CardData cardData*/)
    {
    //    ID = cardData.ID;
    //    cardVisual.SetIcon(cardData.iconSprite);
    //    Close();
    }
    public void Select()
    {
        transform.eulerAngles = new Vector3(0,0,0);
    }
    public void Deselect()
    {
        transform.eulerAngles = new Vector3 (0,180,0);
    }
}
