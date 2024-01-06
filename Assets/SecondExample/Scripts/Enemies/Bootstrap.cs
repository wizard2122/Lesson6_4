using UnityEngine;
using Zenject;

public class Bootstrap : MonoBehaviour
{
    [SerializeField] private EnemySpawner _spawner;

    private PauseHandler _pauseHandler;

    [Inject]
    private void Construct(PauseHandler pauseHandler)
    {
        _pauseHandler = pauseHandler;
    }

    private void Awake()
    {
        _spawner.StartWork();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
            _pauseHandler.SetPause(true);

        if(Input.GetKeyDown(KeyCode.W))
            _pauseHandler.SetPause(false);
    }
}
