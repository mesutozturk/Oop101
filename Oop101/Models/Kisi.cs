using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oop101.Business;

namespace Oop101.Models
{
    //Erişim Belirleyici - Access Modifiers
    //Public -- Bulunduğu projeden ve Referans verildiği projelerden erişilebilir
    //Private -- Sadece tanımlandığı scope(parantez) içerisinden erişilebilir.
    //Internal -- Sadece bulunduğu projeden erişilebilir.
    //protected
    //protected internal

    //default access modifiers
    //class interface enum vb gibi nesnelerin internal'dir
    //değişken method ve field ların private'dir.


    //PascalCase - camelCase
    public class Kisi
    {
        //Field
        //Constructor
        //Property
        //Method

        //ad-soyad-email-telefon-tckn-----
        public Kisi()
        {

        }
        public Kisi(string ad, string soyad)
        {
            if (ad.Contains("0"))
            {

                throw new Exception("Ad alanında sadece harf bulunmalıdır");
            }

            if (soyad.Contains("0"))
            {
                throw new Exception("Soyad alanında sadece harf bulunmalıdır");
            }

            _ad = ad;
            _soyad = soyad;
        }

        private string _ad;
        private string _soyad;
        private DateTime _dogumTarihi;
        private string _tckn;


        public void SetAd(string ad)
        {
            foreach (var harf in ad)
            {
                if (char.IsDigit(harf) || char.IsNumber(harf))
                    throw new Exception("Ad alanında sadece harf bulunmalıdır");
            }
            _ad = ad;
        }

        public string GetAd()
        {
            return _ad.Substring(0, 1).ToUpper() + _ad.Substring(1).ToLower();
        }

        public string Ad //Full Property
        {
            get
            {
                return _ad.Substring(0, 1).ToUpper() + _ad.Substring(1).ToLower();
            }
            set
            {
                foreach (var harf in value)
                {
                    if (char.IsDigit(harf) || char.IsNumber(harf))
                        throw new Exception("Ad alanında sadece harf bulunmalıdır");
                }
                _ad = value;
            }
        }
        public string Soyad
        {
            set
            {
                foreach (var harf in value)
                {
                    if (char.IsDigit(harf) || char.IsNumber(harf))
                        throw new Exception("Soyad alanında sadece harf bulunmalıdır");
                }

                _soyad = value;
            }
            get
            {
                string soyad = _soyad.Substring(0, 1).ToUpper() + _soyad.Substring(1).ToLower();
                return soyad;
            }
        }
        public DateTime DogumTarihi
        {
            get { return _dogumTarihi; }
            set
            {
                TimeSpan fark = DateTime.Now - value;
                double yas = fark.TotalDays / 365;
                if (yas < 18)
                    throw new Exception("18 yaşından küçükleri sisteme kayıt edemezsiniz");

                _dogumTarihi = value;
            }
        }

        public string Telefon { get; set; } //Auto Property
        public string Email { get; set; }
        public string Tckn
        {
            get { return _tckn; }
            set { _tckn = value; }
        }
        public int Yas //read-only property
        {
            get
            {
                int yas = DateTime.Now.Year - _dogumTarihi.Year;
                return yas;
            }
        }


        public override string ToString()
        {
            return $"{Ad} {Soyad} - {Yas}";
        }
    }
}