using UnityEngine;

public class Barrel : MonoBehaviour, iDamagable
{
    [SerializeField] AudioClip m_AudioClip;
    AudioSource m_AudioSource;

    [SerializeField] ParticleSystem splinters;

    private void Start()
    {
        m_AudioSource = GetComponent<AudioSource>();
    }

    public void TakeDamage()
    {
        m_AudioSource.PlayOneShot(m_AudioClip);
        splinters.Play();
    }

}
