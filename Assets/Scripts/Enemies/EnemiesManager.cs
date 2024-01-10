using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesManager : MonoBehaviour
{
    #region Singleton

    private static EnemiesManager Instance { get; set; }

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;

        Init();
    }

    #endregion

    #region Core Behaviour

    private void Init()
    {

    }

    private void Update()
    {
        if (GameManager.IsPlaying)
        {
            UpdateEnemies();
        }
    }

    #endregion

    #region Enemies Registration

    private List<BaseEnemy> m_enemies = new();

    public static void Register(BaseEnemy enemy)
    {
        if (enemy != null && !Instance.m_enemies.Contains(enemy))
        {
            Instance.m_enemies.Add(enemy);
        }
    }
    public static void Unregister(BaseEnemy enemy)
    {
        if (enemy != null && Instance.m_enemies.Contains(enemy))
        {
            Instance.m_enemies.Remove(enemy);
        }
    }

    #endregion

    #region Enemies Update

    private void UpdateEnemies()
    {
        foreach (var enemy in Instance.m_enemies)
        {

        }
    }

    #endregion
}
