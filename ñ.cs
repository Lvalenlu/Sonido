using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ñ : MonoBehaviour
{
   
   public gameObject obj;
   [Range20,20000]
    public float Frecuencia;
    public float FrecuenciadeMuestreo = 44100;
    public float TiempoSegundos = 2.0f;
    int TimeIndex = 0;
    AudioSource fuente;
    // Start is called before the first frame update
    /*void Start()
    {
        fuente = gameObject.AddComponent<AudioSource>();
        fuente.playOnAwake = false;
        fuente.spatialBlend = 0;
        fuente.Stop();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)){
            if(!fuente.isPlaying);
            {
                TimeIndex = 0;
                fuente.Play();
            }
            else{
               fuente.Stop();
            }
        }
        if (Input.GetKeyDown(KeyCode.A)){
            if(!fuente.isPlaying);
            {
                TimeIndex = 0;
                fuente.Play();
            }
            else{
               fuente.Stop();
            }
        }
    }
    int selector = 0

    void OnAudioFilterRead(float{} data, int channels){
        if (selector == 0){
            for (int i =0; i < data.Length; i += channels){
                data[i] = CreateSeno(TimeIndex, Frecuencia, FrecuanciadeMuestreo);

                if (channels==2)
                    data[i+1] = CreateSeno(TimeIndex, Frecuencia, FrecuanciadeMuestreo);
                TimeIndex++;

                if (TimeIndex >= (FrecuenciaMuestreo*TiempoSegundos))
                    TimeIndex = 0;
            }
        }
        else if (selector == 1)
        {
            for (int i =0; i < data.Length; i += channels){
            data[i] = CreateSeno(TimeIndex, Frecuencia, FrecuanciadeMuestreo);

            if (channels==2)
                data[i+1] = CreateSeno(TimeIndex, Frecuencia, FrecuanciadeMuestreo);
            TimeIndex++;

            if (TimeIndex >= (FrecuenciaMuestreo*TiempoSegundos))
                TimeIndex = 0;
            }
        }
        
     }

    public float CreateSeno(int TimeIndex, float Frecuencia, float FrecuanciadeMuestreo) {
        return Math.Sin(2 * Mathf.PI * Frecuencia * TimeIndex / FrecuenciaMuestreo);
    }
    
    public float CreateSquare(int TimeIndex, float Frecuencia, float FrecuanciadeMuestreo)
    {
        if (Math.Sin(2 * Mathf.PI * Frecuencia * TimeIndex / FrecuenciaMuestreo)>0)
            return 1;
        else if(Math.Sin(2 * Mathf.PI * Frecuencia * TimeIndex / FrecuenciaMuestreo)<0)
            return -1;
        else
            return 0;
    }*/
}
