using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;

namespace MVP
{
    public class UIView : View, IDisposable
    {
        [SerializeField] private TextMeshProUGUI _text;
        [SerializeField] private Button _addButton;

        public void Start()
            => _addButton.onClick.AddListener(OnAddClicked);

        public void Dispose()
            => _addButton.onClick.RemoveListener(OnAddClicked);

        public void OnAddClicked()
            => _presenter.OnAddButtonClicked();

        public override void DisplayScoreText(int values)
            => _text.text = values.ToString();
    }
}
