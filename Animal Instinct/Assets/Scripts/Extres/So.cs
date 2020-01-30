using UnityEngine;
using UnityEngine.Audio;
using System.Collections;

public class So : MonoBehaviour {

    public AudioMixer EfectesMix;

    public void Efectesvol(float efectes)
    {
        EfectesMix.SetFloat("Efectes", efectes);
    }

    public void musicavol(float musica)
    {
        EfectesMix.SetFloat("Musicavol", musica);
    }
}
