using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;

public class EasyProject_by_Flo : Editor
{
    [MenuItem("EasyProject/Create base 3D project", priority = 1)]
    static void createComplete3DProject()
    {
        createBase3DProject();
        createDefaultMats();
    }


    [MenuItem("EasyProject/Step by step/Create empty 3D project")]
    static void createBase3DProject()
    {
        string appRoot = Application.dataPath;

        Directory.CreateDirectory(appRoot + "/Custom assets");
        Directory.CreateDirectory(appRoot + "/Custom assets/_Scenes");
        Directory.CreateDirectory(appRoot + "/Custom assets/Materials");
        Directory.CreateDirectory(appRoot + "/Custom assets/Materials/Default");
        Directory.CreateDirectory(appRoot + "/Custom assets/Prefabs");
        Directory.CreateDirectory(appRoot + "/Custom assets/Textures");
        Directory.CreateDirectory(appRoot + "/Custom assets/Shaders");
        Directory.CreateDirectory(appRoot + "/Custom assets/Scripts");
        Directory.CreateDirectory(appRoot + "/Custom assets/Scripts/Editor");

        Directory.Move(appRoot + "/EasyProject_by_Flo.cs", appRoot + "/Custom assets/Scripts/Editor/EasyProject_by_Flo.cs");

        Debug.Log("Created Directories and moved EasyProject script.");
    }

    [MenuItem("EasyProject/Step by step/Create default materials")]
    static void createDefaultMats()
    {
        Material matR = new Material(Shader.Find("Standard"));
        matR.color = Color.red;
        AssetDatabase.CreateAsset(matR, "Assets/Custom assets/Materials/Default/red_default.mat");

        Material matB = new Material(Shader.Find("Standard"));
        matB.color = Color.blue;
        AssetDatabase.CreateAsset(matB, "Assets/Custom assets/Materials/Default/blue_default.mat");

        Material matG = new Material(Shader.Find("Standard"));
        matG.color = Color.green;
        AssetDatabase.CreateAsset(matG, "Assets/Custom assets/Materials/Default/green_default.mat");

        Material matW = new Material(Shader.Find("Standard"));
        matW.color = Color.white;
        AssetDatabase.CreateAsset(matW, "Assets/Custom assets/Materials/Default/white_default.mat");

        Material matBc = new Material(Shader.Find("Standard"));
        matBc.color = Color.black;
        AssetDatabase.CreateAsset(matBc, "Assets/Custom assets/Materials/Default/black_default.mat");

        Material matMetal = new Material(Shader.Find("Standard"));
        matMetal.color = new Color(0.8f, 0.8f, 0.9f);
        matMetal.SetFloat("_Metallic", 1);
        AssetDatabase.CreateAsset(matMetal, "Assets/Custom assets/Materials/Default/metal_default.mat");

        Debug.Log("Created default materials");
    }
}
