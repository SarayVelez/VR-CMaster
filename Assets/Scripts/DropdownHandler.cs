using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropdownHandler : MonoBehaviour
{
    public GameObject menuOpc;
    public GameObject gabs;
    public GameObject dd;
    public GameObject fuente;
    public GameObject mono;
    public GameObject rat;
    public GameObject procesador;
    public GameObject ram;
    public GameObject gpu;
    public GameObject mother;
    public GameObject fan;
    public GameObject keyb;
    public Dropdown dropdown;


    public void OnDropdownValueChanged(){
        
        int chosenInt = dropdown.value;

        if(chosenInt==1){
                // Mostrar objetos relacionados con la opción Gabinetes
                gabs.SetActive(true);

                // Ocultar objetos relacionados con otras opciones
                menuOpc.SetActive(false);
                /*dd.SetActive(false);
                fuente.SetActive(false);
                mono.SetActive(false);
                rat.SetActive(false);
                procesador.SetActive(false);
                ram.SetActive(false);
                gpu.SetActive(false);
                mother.SetActive(false);
                fan.SetActive(false);
                keyb.SetActive(false);*/
        }else if(chosenInt==2){
    
                // Mostrar objetos relacionados con la opción Discos Duros
                dd.SetActive(true);

                // Ocultar objetos relacionados con otras opciones
                menuOpc.SetActive(false);
                /*gabs.SetActive(false);
                fuente.SetActive(false);
                mono.SetActive(false);
                rat.SetActive(false);
                procesador.SetActive(false);
                ram.SetActive(false);
                gpu.SetActive(false);
                mother.SetActive(false);
                fan.SetActive(false);
                keyb.SetActive(false);*/
        }else if(chosenInt==3){

                // Mostrar objetos relacionados con la opción Fuentes
                fuente.SetActive(true);

                // Ocultar objetos relacionados con otras opciones
                menuOpc.SetActive(false);
                /*gabs.SetActive(false);
                dd.SetActive(false);
                mono.SetActive(false);
                rat.SetActive(false);
                procesador.SetActive(false);
                ram.SetActive(false);
                gpu.SetActive(false);
                mother.SetActive(false);
                fan.SetActive(false);
                keyb.SetActive(false);*/
        }else if(chosenInt==4){
    
                // Mostrar objetos relacionados con la opción Fuentes
                mono.SetActive(true);

                // Ocultar objetos relacionados con otras opciones
                menuOpc.SetActive(false);
                /*gabs.SetActive(false);
                dd.SetActive(false);
                fuente.SetActive(false);
                rat.SetActive(false);
                procesador.SetActive(false);
                ram.SetActive(false);
                gpu.SetActive(false);
                mother.SetActive(false);
                fan.SetActive(false);
                keyb.SetActive(false);*/
        }else if(chosenInt==5){

                // Mostrar objetos relacionados con la opción Fuentes
                rat.SetActive(true);

                // Ocultar objetos relacionados con otras opciones
                menuOpc.SetActive(false);
                /*gabs.SetActive(false);
                dd.SetActive(false);
                fuente.SetActive(false);
                mono.SetActive(false);
                procesador.SetActive(false);
                ram.SetActive(false);
                gpu.SetActive(false);
                mother.SetActive(false);
                fan.SetActive(false);
                keyb.SetActive(false);*/
        }else if(chosenInt==6){
                // Mostrar objetos relacionados con la opción Fuentes
                procesador.SetActive(true);

                // Ocultar objetos relacionados con otras opciones
                menuOpc.SetActive(false);
                /*gabs.SetActive(false);
                dd.SetActive(false);
                fuente.SetActive(false);
                mono.SetActive(false);
                rat.SetActive(false);
                ram.SetActive(false);
                gpu.SetActive(false);
                mother.SetActive(false);
                fan.SetActive(false);
                keyb.SetActive(false);*/
        }else if(chosenInt==7){
                // Mostrar objetos relacionados con la opción Fuentes
                ram.SetActive(true);

                // Ocultar objetos relacionados con otras opciones
                menuOpc.SetActive(false);
                /*gabs.SetActive(false);
                dd.SetActive(false);
                fuente.SetActive(false);
                mono.SetActive(false);
                rat.SetActive(false);
                procesador.SetActive(false);
                gpu.SetActive(false);
                mother.SetActive(false);
                fan.SetActive(false);
                keyb.SetActive(false);*/
        }else if(chosenInt==8){
                // Mostrar objetos relacionados con la opción Fuentes
                gpu.SetActive(true);

                // Ocultar objetos relacionados con otras opciones
                menuOpc.SetActive(false);
                /*gabs.SetActive(false);
                dd.SetActive(false);
                fuente.SetActive(false);
                mono.SetActive(false);
                rat.SetActive(false);
                procesador.SetActive(false);
                ram.SetActive(false);
                mother.SetActive(false);
                fan.SetActive(false);
                keyb.SetActive(false);*/
        }else if(chosenInt==9){
                // Mostrar objetos relacionados con la opción Fuentes
                mother.SetActive(true);

                // Ocultar objetos relacionados con otras opciones
                menuOpc.SetActive(false);
                /*gabs.SetActive(false);
                dd.SetActive(false);
                fuente.SetActive(false);
                mono.SetActive(false);
                rat.SetActive(false);
                procesador.SetActive(false);
                ram.SetActive(false);
                gpu.SetActive(false);
                fan.SetActive(false);
                keyb.SetActive(false);*/
        }else if(chosenInt==10){
                // Mostrar objetos relacionados con la opción Fuentes
                fan.SetActive(true);

                // Ocultar objetos relacionados con otras opciones
                menuOpc.SetActive(false);
                /*gabs.SetActive(false);
                dd.SetActive(false);
                fuente.SetActive(false);
                mono.SetActive(false);
                rat.SetActive(false);
                procesador.SetActive(false);
                ram.SetActive(false);
                gpu.SetActive(false);
                mother.SetActive(false);
                keyb.SetActive(false);*/
        }else if(chosenInt==11){
                // Mostrar objetos relacionados con la opción Fuentes
                keyb.SetActive(true);

                // Ocultar objetos relacionados con otras opciones
                menuOpc.SetActive(false);
                /*gabs.SetActive(false);
                dd.SetActive(false);
                fuente.SetActive(false);
                mono.SetActive(false);
                rat.SetActive(false);
                procesador.SetActive(false);
                ram.SetActive(false);
                gpu.SetActive(false);
                mother.SetActive(false);
                fan.SetActive(false);*/
        }
    }
}
