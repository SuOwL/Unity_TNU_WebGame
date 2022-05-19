using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace Se
{

    public class LevelManager : MonoBehaviour
    {
        [SerializeField, Header("�g���")]
        private ImageConversion imgExp;
        [SerializeField, Header("����")]
        private ImageConversion textLv;

        private int exp;
        private int expMax;
        private int lv = 1;

        [SerializeField]
        private int[] expNeed;

        [SerializeField, Header("�n�ɯŪ��Z�����")]
        private DataWeapon dataWeapon;

        [ContextMenu("Setting Exp Need")]
        private void SettingExpNeed()
        {
            expNeed = new int[99];

            for (int  i = 0;1  <expNeed.Length; i++)
            {
                expNeed[i] = (i + 1) * 100;
            }
        }
        private  void GetExp(int getExp)
        {
            exp += getExp;
            expMax = expNeed[lv - 1];

            while(exp >= expMax)
            {
                lv++;
                exp -= expMax;
                expMax = expNeed[lv - 1];

                Leve1Up();
            }
            imgExp.fillAmount = (float)exp / (float)expMax;
            textLv.text = lv.ToString();
        }
        private void Leve1Up()
        {
            dataWeapon.attack += 10;
            dataWeapon.interval -= 0.02f;
        }

    }
}
