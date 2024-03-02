using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingView : MonoBehaviour
{
    public Slider loadingSlider;
    public Text progressText;

    private AsyncOperation _operation;
    private const float LERP_SPEED = 2f;
    private void Start()
    {
        // 异步加载场景
        _operation = SceneManager.LoadSceneAsync("Game");
        // 禁止场景在加载完成前自动切换
        _operation.allowSceneActivation = false;
        // 启动异步加载场景的协程
        StartCoroutine(LoadSceneAsync());
    }

    IEnumerator LoadSceneAsync()
    {
        while (!_operation.isDone)
        {
            // 计算加载进度（注意：operation.progress 的最大值为 0.9）
            float targetProgress = Mathf.Clamp01(_operation.progress / 0.9f);

            // 使用差值运算平滑地更新Slider的值
            loadingSlider.value = Mathf.Lerp(loadingSlider.value, targetProgress, Time.deltaTime * LERP_SPEED);
            progressText.text = $"{loadingSlider.value*100:N0}%";
            // 如果加载完成（progress 达到 1），则激活场景切换
            if (loadingSlider.value >= 0.98f)
            {
                _operation.allowSceneActivation = true;
            }

            yield return null;
        }
    }
}
