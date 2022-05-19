

using UnityEngine;
using UnityEngine.UI;
using System.Collections;


namespace Se
{
    public class HurtNumberEffect : MonoBehaviour
    {
        [SerializeField, Header("�H�J�H�X�C�@����"), Range(0, 0.3f)]
        private float valueFade = 0.1f;
        [SerializeField, Header("��j�Y�p�C�@����"), Range(0, 0.1f)]
        private float valueScale = 0.1f;
        [SerializeField, Header("�첾�C�@����"), Range(0, 100)]
        private float valueOffset = 10;

        private CanvasGroup group;
        private RectTransform rect;
        private Text textDamage;

        private void Awake()
        {
            textDamage = transform.Find("�ˮ`��").GetComponent<Text>();
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
            print("�ڬO�Ĥ@��");
            yield return new WaitForSeconds(1);

            print("�@���A�ڬO�ĤG��");
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


