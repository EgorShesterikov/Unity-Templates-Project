using UnityEngine;
using TMPro;

namespace MVC
{
    public class UIView : View
    {
        [SerializeField] private TextMeshProUGUI _text;

        public override void DisplayScoreText(int values)
            => _text.text = values.ToString();
    }
}
