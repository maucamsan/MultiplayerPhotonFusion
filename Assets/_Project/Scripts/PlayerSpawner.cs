using Fusion;
using System;
using UnityEngine;

public class PlayerSpawner : SimulationBehaviour, IPlayerJoined
{
    public GameObject PlayerPrefab;
    public static event Action OnNewPlayerJoined;

    public void PlayerJoined(PlayerRef player)
    {
        if (player == Runner.LocalPlayer )
        {
            Runner.Spawn(PlayerPrefab, new Vector3(0, 1, 0), Quaternion.identity);
            OnNewPlayerJoined?.Invoke();
        }
    }
}
