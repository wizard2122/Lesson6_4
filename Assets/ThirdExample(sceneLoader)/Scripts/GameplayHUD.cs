using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class GameplayHUD : MonoBehaviour
{
    [SerializeField] private Button _mainMenuButton;

    private ISceneLoadMediator _sceneLoader;
    private LevelLoadingData _loadingData;
    private Wallet _wallet;

    [Inject]
    private void Construct(ISceneLoadMediator sceneLoadMediator, LevelLoadingData levelLoadingData, Wallet wallet)
    {
        _sceneLoader = sceneLoadMediator;
        _loadingData = levelLoadingData;
        _wallet = wallet;
        Debug.Log($"Уровень {_loadingData.Level}");
    }

    private void OnEnable()
        => _mainMenuButton.onClick.AddListener(OnMainMenuClick);

    private void OnDisable()
        => _mainMenuButton.onClick.RemoveListener(OnMainMenuClick);

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            _wallet.AddCoins(10);

        if (Input.GetKeyDown(KeyCode.S))
            if (_wallet.IsEnough(10))
                _wallet.Spend(10);
    }

    private void OnMainMenuClick() => _sceneLoader.GoToMainMenu();
}
