using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace UnityEngine.Formats.Fbx.Exporter
{
	internal class FbxPrefab : MonoBehaviour
	{
		[SerializeField]
		private string m_fbxHistory;

		[SerializeField]
		private List<StringPair> m_nameMapping;

		[SerializeField]
		[Tooltip("Which FBX file does this refer to?")]
		private GameObject m_fbxModel;

		[Tooltip("Should we auto-update this prefab when the FBX file is updated?")]
		[SerializeField]
		private bool m_autoUpdate;

		public string FbxHistory
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<StringPair> NameMapping => null;

		public GameObject FbxModel
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool AutoUpdate
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static event HandleUpdate OnUpdate
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static void CallOnUpdate(FbxPrefab instance, IEnumerable<GameObject> updatedObjects)
		{
		}
	}
}
