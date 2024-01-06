public class SceneLoadMediator : ISceneLoadMediator
{
    private ISimpleSceneLoader _simpleSceneLoader;
    private ILevelLoader _levelLoader;

    public SceneLoadMediator(ISimpleSceneLoader simpleSceneLoader, ILevelLoader levelLoader)
    {
        _simpleSceneLoader = simpleSceneLoader;
        _levelLoader = levelLoader;
    }

    public void GoToGameplayLevel(LevelLoadingData levelLoadingData)
        => _levelLoader.Load(levelLoadingData);

    public void GoToLevelSelectioMenu()
        => _simpleSceneLoader.Load(SceneID.LevelSelection);

    public void GoToMainMenu()
        => _simpleSceneLoader.Load(SceneID.MainMenu);
}
