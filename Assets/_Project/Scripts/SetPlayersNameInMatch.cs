using Fusion;
using UnityEngine;
using TMPro;

public class SetPlayersNameInMatch : NetworkBehaviour, IPlayerJoined
{
    [SerializeField] TMP_Text playersNameDisplay;
    [Networked, OnChangedRender(nameof(NameSet))]
    public string PlayersName {get; set;}
    public StringVariable stringVariable;
    
    void OnEnable()
    {
        PlayerSpawner.OnNewPlayerJoined += UpdateOnNewPlayer;
    }

    void OnDisable()
    {
        PlayerSpawner.OnNewPlayerJoined -= UpdateOnNewPlayer;
        
    }

    private void UpdateOnNewPlayer()
    {
        if (HasStateAuthority)
            PlayersName = stringVariable.UserName;
    }
    public void NameSet()
    {
        playersNameDisplay.text = PlayersName;
    }

    public void PlayerJoined(PlayerRef player)
    {
        playersNameDisplay.text = stringVariable.UserName;
    }
}
