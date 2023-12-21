using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CardSystem
{
    public class CardCreator : MonoBehaviour
    {
        [SerializeField] private GameObject _hand;
        [SerializeField] private Card _card;

        public void AddCardToHand(CardSO card)
        {
            var newCard = Instantiate(_card, _hand.transform);
            newCard.GetComponent<CardInfoParser>().SetCardScriptable(card);
            newCard.GetComponent<CardInfoParser>().ParseCardInfo();
        }
    }
}


