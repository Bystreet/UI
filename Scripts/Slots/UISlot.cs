// =======================================================================================
// UISlot
// by Weaver (Fhiz)
// MIT licensed
// =======================================================================================

using UnityEngine;
using UnityEngine.UI;
using wovencode;

namespace wovencode
{
	
	// ===================================================================================
	// UISlot
	// ===================================================================================
	public abstract partial class UISlot<T> : UIRoot
	{
	
    	public Button button;
    	
    	[Header("Image")]
		public Image image;
		public Image backgroundImage;
		public Image borderImage;
		
		[Header("Label")]
		public GameObject labelOverlay;
		public Text textLabel;
		
		[Header("Value")]
		public GameObject valueOverlay;
		public Text textValue;
				
		[Header("Timer")]
		public GameObject timerOverlay;
    	public Text timerText;
    	public Image timerCircle;
    	
		protected GameObject		localPlayer = null;
		protected T					entry;
		
		// -------------------------------------------------------------------------------
		public virtual void Init(ref T _entry)
		{
#if wPLAYER
			localPlayer 			= PlayerComponent.localPlayer;
#endif
			entry 					= _entry;
		}
		
		// -------------------------------------------------------------------------------
		public virtual void Reset()
		{
			image.sprite = null;
			valueOverlay.SetActive(false);
			timerOverlay.SetActive(false);
			button.onClick.RemoveAllListeners();
		}
		
		// -------------------------------------------------------------------------------
		
	}

}

// =======================================================================================