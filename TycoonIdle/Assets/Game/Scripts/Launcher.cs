using System;
using System.Collections;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using ProjectEnums;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Launcher : MonoBehaviour
{
    private async void Awake()
    {
        await SceneManager.LoadSceneAsync(SceneName.MainScene.ToString(), LoadSceneMode.Single);
    }
}
