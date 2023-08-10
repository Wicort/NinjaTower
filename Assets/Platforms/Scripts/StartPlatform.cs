using UnityEngine;

public class StartPlatform : Platform
{
    [SerializeField] private Player _player;
    [SerializeField] private Transform _spawnPoint;

    private void Start()
    {
        Player player = Instantiate(_player, _spawnPoint.position, Quaternion.identity);
    }
}
