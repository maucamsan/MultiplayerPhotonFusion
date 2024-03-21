using Fusion;
using UnityEngine;
using TMPro;

public class SetPlayersNameInMatch : NetworkBehaviour
{
    [SerializeField] TMP_Text playersNameDisplay;
    [Networked, OnChangedRender(nameof(NameSet))]
    public string PlayersName {get; set;}
    public StringVariable stringVariable;
    private bool hasNameSet;
    
    void OnEnable()
    {
        PlayerSpawner.OnNewPlayerJoined += UpdateOnNewPlayer;
        playersNameDisplay.text = stringVariable.UserName;
        UpdateOnNewPlayer();
    }

    void OnDisable()
    {
        PlayerSpawner.OnNewPlayerJoined -= UpdateOnNewPlayer;
        
    }

    private void UpdateOnNewPlayer()
    {
        if (HasStateAuthority && !hasNameSet)
            PlayersName = stringVariable.UserName;
        hasNameSet = true;
    }
    public void NameSet()
    {
        playersNameDisplay.text = PlayersName;
    }
    
}
