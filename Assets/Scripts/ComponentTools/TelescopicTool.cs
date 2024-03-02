using DG.Tweening;
using UnityEngine;

namespace ComponentTools
{
    public class TelescopicTool : MonoBehaviour
    {
        private Vector3 _minScale;
        private Vector3 _maxScale;
        private bool _flag;
        [SerializeField,Range(1f, 2f),Header("放大倍数")] private float magnification = 1.2f;
        [SerializeField,Range(0f, 5f),Header("伸缩持续时间")] private float magnificationSpeed = 0.6f;
    
        private void Start()
        {
            _minScale = transform.localScale;
            _maxScale = _minScale * magnification;
            StartCartoon();
        }
        /// <summary>
        /// 缩放动画
        /// </summary>
        private void StartCartoon()
        {
            if (!_flag)
            {
                return;
            }
            transform.DOScale(_maxScale,magnificationSpeed)
                .SetEase(Ease.Linear)
                .OnComplete(delegate
                {
                    transform.DOScale(_minScale, magnificationSpeed)
                        .SetEase(Ease.Linear)
                        .OnComplete(StartCartoon);
                });
        }
 
        private void OnEnable()
        {
            _flag = true;
            _minScale = transform.localScale;
            _maxScale = _minScale * magnification;
            StartCartoon();
        }
 
        private void OnDisable()
        {
            _flag = false;
        }
    }
}