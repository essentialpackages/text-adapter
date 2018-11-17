using TMPro;
using UnityEngine;

namespace EssentialPackages.UI.TextAdapters
{
	public class TextMeshProUGUIAdapter : TextAdapterBase
	{
		[SerializeField] private TextMeshProUGUI _text;

		public override void SetText(string value)
		{
			if (_text != null) _text.text = value;
		}
	}
}
