using UnityEngine;
using UnityEngine.UI;

namespace EssentialPackages.UI.TextAdapters
{
	public class TextAdapter : TextAdapterBase
	{
		[SerializeField] private Text _text;

		public override void SetText(string value)
		{
			if (_text != null) _text.text = value;
		}
	}
}
