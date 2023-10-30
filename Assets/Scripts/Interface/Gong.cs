
using UnityEngine;

public class Gong : MonoBehaviour, iDamagable
{
    [SerializeField] AudioClip m_AudioClip;
    AudioSource m_AudioSource;

    private void Start()
    {
        m_AudioSource = GetComponent<AudioSource>();
    }

    public void TakeDamage()
    {
        m_AudioSource.PlayOneShot(m_AudioClip);
    }
}
