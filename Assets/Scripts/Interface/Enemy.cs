using UnityEngine;

public class Enemy : MonoBehaviour, iDamagable
{
    [SerializeField] AudioClip m_AudioClip;
    AudioSource m_AudioSource;

    [SerializeField] ParticleSystem blood;

    private void Start()
    {
        m_AudioSource = GetComponent<AudioSource>();
    }

    public void TakeDamage()
    {
        blood.Emit(50);
        m_AudioSource.PlayOneShot(m_AudioClip);
    }
}
