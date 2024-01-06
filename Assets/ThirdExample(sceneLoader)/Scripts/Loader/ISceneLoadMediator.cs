public interface ISceneLoadMediator
{
    void GoToMainMenu();
    void GoToLevelSelectioMenu();
    void GoToGameplayLevel(LevelLoadingData levelLoadingData);
}
