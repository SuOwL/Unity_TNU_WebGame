

using UnityEngine;
using UnityEngine.UI;
using System.Collections;


namespace Se
{
    public class HurtNumberEffect : MonoBehaviour
    {
        [SerializeField, Header("淡入淡出每一次值"), Range(0, 0.3f)]
        private float valueFade = 0.1f;
        [SerializeField, Header("放大縮小每一次值"), Range(0, 0.1f)]
        private float valueScale = 0.1f;
        [SerializeField, Header("位移每一次值"), Range(0, 100)]
        private float valueOffset = 10;

        private CanvasGroup group;
        private RectTransform rect;
        private Text textDamage;

        private void Awake()
        {
            textDamage = transform.Find("傷害值").GetComponent<Text>();
        }

        private void Start()
        {
            group = GetComponent<CanvasGroup>();
            rect = GetComponent<RectTransform>();

            StartCoroutine(Fade());
            StartCoroutine(Scale());
            StartCoroutine(Offset());
        }
        public void UpdateDamage(float getDamage)
        {
            textDamage.text = getDamage.ToString();
        }
            
        private IEnumerator Test()
        {
            print("我是第一行");
            yield return new WaitForSeconds(1);

            print("一秒後，我是第二行");
        }
        private IEnumerator Fade()
        {
            for(int i = 0;i <10;i++)
            {
                group.alpha += valueFade;
                yield return new WaitForSeconds(0.02f);
            }
        }
        private IEnumerator Scale()
        {
            for (int i =0;i<5;i++)
            {
                rect.localScale += new Vector3(valueScale, valueScale, 0);
                yield return new WaitForSeconds(0.02f);
            }
        }
        private IEnumerator Offset()
        {
            for (int i = 0; i < 10; i++)
            {
                rect.anchoredPosition += Vector2.up * valueOffset;
                yield return new WaitForSeconds(0.02f);
            }
        }
    }
}


