// =======================================================================================
// Define
// by Weaver (Fhiz)
// MIT licensed
// =======================================================================================

#if UNITY_EDITOR

using wovencode;
using UnityEditor;
using UnityEngine;

namespace wovencode
{

	public partial class DefinesManager
	{

		[DevExtMethods("Constructor")]
		public static void Constructor_UI()
		{
			EditorTools.AddScriptingDefine("wUI");
		}

	}

}

#endif