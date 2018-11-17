using EssentialPackages.UI.TextAdapters.Interfaces;
using UnityEngine;

namespace EssentialPackages.UI.TextAdapters
{
	public abstract class TextAdapterBase : MonoBehaviour, ITextComponent
	{
		[SerializeField] private string _id;

		public string Id => _id;

		public abstract void SetText(string value);
	}
}
