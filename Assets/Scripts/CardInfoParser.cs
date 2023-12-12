using Codice.CM.SEIDInfo;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CardInfoParser : MonoBehaviour
{
    [SerializeField] private CardSO _cardSO;

    [SerializeField] private TMP_Text _title;
    [SerializeField] private TMP_Text _description;
    [SerializeField] private Image _image;
    [SerializeField] private TMP_Text _cost;


    private void Start()
    {
        ParseCardInfo();
    }

    void ParseCardInfo()
    {
        _title.text = _cardSO.Title;
        _image.sprite = _cardSO.Sprite;
        _description.text = _cardSO.Description;
        _cost.text = _cardSO.Cost.ToString();


        var card = GetComponent<Card>();
        card.Cost = _cardSO.Cost;
        card.ActionScript = _cardSO.ActionScript;
        card.Sprite = _cardSO.Sprite;
    }
}
