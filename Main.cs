using UnityEngine;
using NeoModLoader.api;
using NeoModLoader.services;

namespace DivineFPS;

/// <summary>
/// NeoModLoader entry point. Keep this initialization lightweight; performance
/// features should be added only after profiling a reproducible game scenario.
/// </summary>
public sealed class Main : MonoBehaviour, IMod
{
    private ModDeclare _declaration;
    private GameObject _gameObject;

    public ModDeclare GetDeclaration()
    {
        return _declaration;
    }

    public GameObject GetGameObject()
    {
        return _gameObject;
    }

    public string GetUrl()
    {
        return "https://github.com/LOCKRUS/DivineFPS";
    }

    public void OnLoad(ModDeclare declaration, GameObject gameObject)
    {
        _declaration = declaration;
        _gameObject = gameObject;
        LogService.LogInfo($"[{declaration.Name}] Loaded. Performance features are not enabled yet.");
    }
}
