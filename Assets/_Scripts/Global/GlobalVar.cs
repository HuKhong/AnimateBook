﻿using UnityEngine;
using System.Collections;
using System.IO;
public class GlobalVar {
    public static bool DEBUG = false;
    public static ShareContext shareContext;
    public static string DATA_PATH;
    public static string DB_PATH;
#if DEVELOPMENT_BUILD
		public static string BASE_ASSET_DOWNLOAD_URL = "http://192.168.0.201/unity3d/3dbook_test/";
#else
    public static string BASE_ASSET_DOWNLOAD_URL = "http://www.smallworld3d.com/unity3d/3dbook_test/";
#endif
    public static string BASE_ASSET_URL = "http://192.168.0.201/unity3d/3dbook_test/";
    //public static string BASE_ASSET_DOWNLOAD_URL = "http://10.11.0.14//unity3d/3dbook_test/";
    public static string BOOK_LOADER_SCENE = "BookLoader";
    public static string DOWNLOAD_ASSET_SCENE = "DownloadAsset";
    public static string CATEGORY_SCENE = "BookList";
	public static string BOOK2DDETAIL_SCENE = "Book2DDetail";
    public static string MAINSCENE = "Home";
	public static string LANGUAGE = "vn";
    public static GameObject SETTING_DIALOG;
    static GlobalVar()
    {
        DATA_PATH = Application.persistentDataPath;
        //DATA_PATH = DATA_PATH.Substring(0, DATA_PATH.Length - 5); // for Androj
		//DATA_PATH = DATA_PATH.Substring(0, DATA_PATH.LastIndexOf("/"));	// for Androj
        DATA_PATH += "/Data";
        DB_PATH= Application.persistentDataPath+"/db";

        if (!Directory.Exists(DB_PATH))
        {
            Directory.CreateDirectory(DB_PATH);
        }

        GameObject g = new GameObject("ShareContext");
        shareContext=g.AddComponent<ShareContext>();
    }

}
