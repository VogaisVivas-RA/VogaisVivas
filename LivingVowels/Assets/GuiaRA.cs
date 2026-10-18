using UnityEngine;
using UnityEngine.UI;
using TMPro; 

public class GuiaRA : MonoBehaviour
{
    [Header("Arraste os elementos da UI para aqui")]
    public GameObject moldura; 
    public TextMeshProUGUI textoGuia;

    void Start()
    {
        PerdeuMarcador(); 
    }

    public void AchouMarcador()
    {
        if (moldura != null) moldura.SetActive(false);
        if (textoGuia != null) textoGuia.gameObject.SetActive(false);
    }

    public void PerdeuMarcador()
    {
        if (moldura != null) moldura.SetActive(true); 
        if (textoGuia != null) textoGuia.gameObject.SetActive(true);
        
        if (textoGuia != null) textoGuia.text = "Encontre o marcador";
    }
}