using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Ogrenci
/// </summary>
public class Ogrenci
{ string tc, ad, soyad, sfr, email, bolum,sinif;
    public Ogrenci()
    {
       
    }

    public string Tc { get => tc; set => tc = value; }
    public string Ad { get => ad; set => ad = value; }
    public string Soyad { get => soyad; set => soyad = value; }   
    public string Sfr { get => sfr; set => sfr = value; }
    public string Email { get => email; set => email = value; }
    public string Bolum { get => bolum; set => bolum = value; }
    public string Sinif { get => sinif; set => sinif = value; }
}