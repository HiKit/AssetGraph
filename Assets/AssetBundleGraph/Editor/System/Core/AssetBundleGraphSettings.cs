using System;
using System.Collections.Generic;
using UnityEditor;

namespace AssetBundleGraph {
	public class AssetBundleGraphSettings {
		/*
			if true, ignore .meta files inside AssetBundleGraph.
		*/
		public const bool IGNORE_META = true;

		public const string GUI_TEXT_MENU_OPEN = "Window/AssetBundleGraph/Open Graph Editor";
		public const string GUI_TEXT_MENU_BUILD = "Window/AssetBundleGraph/Build Bundles for Current Platform";
		public const string GUI_TEXT_MENU_GENERATE = "Window/AssetBundleGraph/Generate Node Script";
		public const string GUI_TEXT_MENU_GENERATE_MODIFIER = GUI_TEXT_MENU_GENERATE + "/Modifier Script";
		public const string GUI_TEXT_MENU_GENERATE_PREFABRICATOR = GUI_TEXT_MENU_GENERATE + "/Prefabricator Script";
		
		public const string GUI_TEXT_MENU_GENERATE_FINALLY = GUI_TEXT_MENU_GENERATE + "/Finally Script";
		public const string GUI_TEXT_MENU_DELETE_CACHE = "Window/AssetBundleGraph/Clear Build Cache";
		
		public const string GUI_TEXT_MENU_DELETE_IMPORTSETTING_SETTINGS = "Window/AssetBundleGraph/Clear Saved ImportSettings";
		public const string GUI_TEXT_MENU_DELETE_MODIFIER_OPERATOR_DATAS = "Window/AssetBundleGraph/Clear Modifier Datas";

		public const string ASSETNBUNDLEGRAPH_DATA_PATH = "AssetBundleGraph/SettingFiles";
		public const string ASSETBUNDLEGRAPH_DATA_NAME = "AssetBundleGraph.json";
		
		public const string ASSETS_PATH = "Assets/";
		public const string ASSETBUNDLEGRAPH_PATH = ASSETS_PATH + "AssetBundleGraph/";
		public const string APPLICATIONDATAPATH_CACHE_PATH = ASSETBUNDLEGRAPH_PATH + "Cache/";
		public const string SCRIPT_TEMPLATE_PATH = ASSETBUNDLEGRAPH_PATH + "Editor/ScriptTemplate/";
		public const string USERSPACE_PATH = ASSETBUNDLEGRAPH_PATH + "Generated/Editor/";
		
		public const string PREFABRICATOR_CACHE_PLACE	= APPLICATIONDATAPATH_CACHE_PATH + "Prefabricated";
//		public const string BUNDLIZER_CACHE_PLACE		= APPLICATIONDATAPATH_CACHE_PATH + "Bundlized";
		public const string BUNDLEBUILDER_CACHE_PLACE	= APPLICATIONDATAPATH_CACHE_PATH + "BundleBuilt";

		public const string IMPORTER_SETTINGS_PLACE		= ASSETBUNDLEGRAPH_PATH + "SavedSettings/ImportSettings";
		public const string MODIFIER_OPERATOR_DATAS_PLACE		= ASSETBUNDLEGRAPH_PATH + "SavedSettings/ModifierOperatorDatas";
		public const string MODIFIER_OPERATOR_DATA_NANE_PREFIX = "modifierOperatorData";
		public const string MODIFIER_OPERATOR_DATA_NANE_SUFFIX = "json";

		public const string UNITY_METAFILE_EXTENSION = ".meta";
		public const string UNITY_LOCAL_DATAPATH = "Assets";
		public const string DOTSTART_HIDDEN_FILE_HEADSTRING = ".";
		public const string MANIFEST_FOOTER = ".manifest";
		public const string IMPORTER_RECORDFILE = ".importedRecord";
		public const char UNITY_FOLDER_SEPARATOR = '/';// Mac/Windows/Linux can use '/' in Unity.

		public const char KEYWORD_WILDCARD = '*';

		public struct BuildAssetBundleOption {
			public readonly BuildAssetBundleOptions option;
			public readonly string description;
			public BuildAssetBundleOption(string desc, BuildAssetBundleOptions opt) {
				option = opt;
				description = desc;
			}
		}

		public static List<BuildAssetBundleOption> BundleOptionSettings = new List<BuildAssetBundleOption> {
			new BuildAssetBundleOption("Uncompressed AssetBundle", BuildAssetBundleOptions.UncompressedAssetBundle),
			new BuildAssetBundleOption("Disable Write TypeTree", BuildAssetBundleOptions.DisableWriteTypeTree),
			new BuildAssetBundleOption("Deterministic AssetBundle", BuildAssetBundleOptions.DeterministicAssetBundle),
			new BuildAssetBundleOption("Force Rebuild AssetBundle", BuildAssetBundleOptions.ForceRebuildAssetBundle),
			new BuildAssetBundleOption("Ignore TypeTree Changes", BuildAssetBundleOptions.IgnoreTypeTreeChanges),
			new BuildAssetBundleOption("Append Hash To AssetBundle Name", BuildAssetBundleOptions.AppendHashToAssetBundleName),
			new BuildAssetBundleOption("ChunkBased Compression", BuildAssetBundleOptions.ChunkBasedCompression),
			new BuildAssetBundleOption("Strict Mode", BuildAssetBundleOptions.StrictMode),
			new BuildAssetBundleOption("Omit Class Versions", BuildAssetBundleOptions.OmitClassVersions)
		};

		//public const string PLATFORM_DEFAULT_NAME = "Default";
		//public const string PLATFORM_STANDALONE = "Standalone";

		public const float WINDOW_SPAN = 20f;

		/*
			node generation from GUI
		*/
		public const string MENU_LOADER_NAME = "Loader";
		public const string MENU_FILTER_NAME = "Filter";
		// public const string MENU_IMPORTER_NAME = "Importer";
		public const string MENU_IMPORTSETTING_NAME = "ImportSetting";
		public const string MENU_MODIFIER_NAME = "Modifier";
		public const string MENU_GROUPING_NAME = "Grouping";
		public const string MENU_PREFABRICATOR_NAME = "Prefabricator";
		public const string MENU_BUNDLIZER_NAME = "Bundlizer";
		public const string MENU_BUNDLEBUILDER_NAME = "BundleBuilder";
		public const string MENU_EXPORTER_NAME = "Exporter";

		public static Dictionary<string, NodeKind> GUI_Menu_Item_TargetGUINodeDict = new Dictionary<string, NodeKind>{
			{"Create " + MENU_LOADER_NAME + " Node", NodeKind.LOADER_GUI},
			{"Create " + MENU_FILTER_NAME + " Node", NodeKind.FILTER_GUI},
			{"Create " + MENU_IMPORTSETTING_NAME + " Node", NodeKind.IMPORTSETTING_GUI},
			{"Create " + MENU_MODIFIER_NAME + " Node", NodeKind.MODIFIER_GUI},
			{"Create " + MENU_GROUPING_NAME + " Node", NodeKind.GROUPING_GUI},
			{"Create " + MENU_PREFABRICATOR_NAME + " Node", NodeKind.PREFABRICATOR_GUI},
			{"Create " + MENU_BUNDLIZER_NAME + " Node", NodeKind.BUNDLIZER_GUI},
			{"Create " + MENU_BUNDLEBUILDER_NAME + " Node", NodeKind.BUNDLEBUILDER_GUI},
			{"Create " + MENU_EXPORTER_NAME + " Node", NodeKind.EXPORTER_GUI}
		};

		public static Dictionary<NodeKind, string> DEFAULT_NODE_NAME = new Dictionary<NodeKind, string>{
			{NodeKind.LOADER_GUI, "Loader"},
			{NodeKind.FILTER_GUI, "Filter"},
			{NodeKind.IMPORTSETTING_GUI, "ImportSetting"},
			{NodeKind.MODIFIER_GUI, "Modifier"},
			{NodeKind.GROUPING_GUI, "Grouping"},
			{NodeKind.PREFABRICATOR_GUI, "Prefabricator"},
			{NodeKind.BUNDLIZER_GUI, "Bundlizer"},
			{NodeKind.BUNDLEBUILDER_GUI, "BundleBuilder"},
			{NodeKind.EXPORTER_GUI, "Exporter"}
		};

		/*
			data key for AssetBundleGraph.json
		*/

		public const string GROUPING_KEYWORD_DEFAULT = "/Group_*/";
		public const string BUNDLIZER_BUNDLENAME_TEMPLATE_DEFAULT = "bundle_*.assetbundle";

		// by default, AssetBundleGraph's node has only 1 InputPoint. and 
		// this is only one definition of it's label.
		public const string DEFAULT_INPUTPOINT_LABEL = "-";
		public const string DEFAULT_OUTPUTPOINT_LABEL = "+";
		public const string BUNDLIZER_BUNDLE_OUTPUTPOINT_LABEL = "bundles";
		public const string BUNDLIZER_VARIANTNAME_DEFAULT = "";

		public const string DEFAULT_FILTER_KEYWORD = "";
		public const string DEFAULT_FILTER_KEYTYPE = "Any";
		
		public const string FILTER_KEYWORD_WILDCARD = "*";
		public const string FILTER_FAKE_CONNECTION_ID = "f_______-____-____-____-____________";
		

		public const string NODE_INPUTPOINT_FIXED_LABEL = "FIXED_INPUTPOINT_ID";

		public static NodeKind NodeKindFromString (string val) {
			return (NodeKind)Enum.Parse(typeof(NodeKind), val);
		}
	}
}
