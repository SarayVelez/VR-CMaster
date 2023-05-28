using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropdownIndex : MonoBehaviour
{
    public Dropdown dropdown;
    public GameObject Option;
    public GameObject gabs;
    public GameObject dd;
    public GameObject fuente;
    public GameObject screen;
    public GameObject rat;
    public GameObject cpu;
    public GameObject ram;
    public GameObject gpu;
    public GameObject mother;
    public GameObject keyb;
    public GameObject fan;


    public void GetSelectedIndex()
    {
        int selectedIndex = dropdown.value;
        if(selectedIndex==1){
            gabs.SetActive(true);
            Option.SetActive(false);
        }else if(selectedIndex==2){
            dd.SetActive(true);
            Option.SetActive(false);
        }else if(selectedIndex==3){
            fuente.SetActive(true);
            Option.SetActive(false);
        }else if(selectedIndex==4){
            screen.SetActive(true);
            Option.SetActive(false);
        }else if(selectedIndex==5){
            rat.SetActive(true);
            Option.SetActive(false);
        }else if(selectedIndex==6){
            cpu.SetActive(true);
            Option.SetActive(false);
        }else if(selectedIndex==7){
            ram.SetActive(true);
            Option.SetActive(false);
        }else if(selectedIndex==8){
            gpu.SetActive(true);
            Option.SetActive(false);
        }else if(selectedIndex==9){
            mother.SetActive(true);
            Option.SetActive(false);
        }else if(selectedIndex==10){
            keyb.SetActive(true);
            Option.SetActive(false);
        }else if(selectedIndex==11){
            fan.SetActive(true);
            Option.SetActive(false);
        }
    }
}
