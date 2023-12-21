using System.Collections.Generic;
using UnityEngine;

namespace CardSystem
{ 
    public class HandBuilder : MonoBehaviour
    {
        [SerializeField] private List<CardSO> _initialHand;

        [SerializeField] private CardCreator _cardCreator;

        private void Start()
        {
            foreach (CardSO card in _initialHand) 
            { 
                _cardCreator.AddCardToHand(card);
            }
        }
    }
}

