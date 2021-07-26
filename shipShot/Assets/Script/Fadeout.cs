using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fadeout : MonoBehaviour
{
    [SerializeField] Image m_fadeImage = default;
    [SerializeField] float m_fadeTime = 1;
    float m_timer = 0;
    bool m_fade = false;

    void Update()
    {
        if (m_fade)
        {
            // Image から Color を取得し、時間の進行に合わせたアルファを設定して Image に戻す
            m_timer += Time.deltaTime;
            Color c = m_fadeImage.color;
            c.a = m_timer / m_fadeTime;
            m_fadeImage.color = c;

            if (m_timer > m_fadeTime)
            {
                // フェード完了
                OnFadeFinished();
            }
        }
    }

    /// <summary>
    /// フェードアウトを開始する
    /// </summary>
    public void Fade()
    {
        m_fade = true;
        Debug.Log("Fade 開始");
    }

    /// <summary>
    /// フェードアウトが終わった時に呼び出す
    /// </summary>
    void OnFadeFinished()
    {
        m_fade = false;
        Debug.Log("Fade 完了");
    }
}
