using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace CardSystem
{
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

        public void SetCardScriptable(CardSO cardSO)
        {
            _cardSO = cardSO;
        }
        public void ParseCardInfo()
        {
            _title.text = _cardSO.Title;
            _image.sprite = _cardSO.CardSprite;
            _description.text = _cardSO.Description;
            _cost.text = _cardSO.Cost.ToString();


            var card = GetComponent<Card>();
            card.CardInfo = _cardSO;
        }
    }
}

