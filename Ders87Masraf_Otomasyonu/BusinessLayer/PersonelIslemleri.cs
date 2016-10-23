
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;//bu using bloğunu kullanabilmek için BusinessLayer'da referencelara DataAcceslayera ekledim
using Common; //referencelara Commonu ekledik
using Entities;//referencelara Entitiesi ekledik.

namespace BusinessLayer
{
    public class PersonelIslemleri
    {
        //global değişken
        private SqlDataProvider provider = new SqlDataProvider(Constants.ConnectionString);//static classtaki static değikenden değeri(connectionStringi) aldım


        public Personel PersoneLogin(string kullaniciAdi, string sifre) //Personel nesnesi döndüren metot.
        {

            //Hata yoksa veritabanına giderek gerekli kullanıcı kontrolleri yapılır.
            //AppConfigHelper'ı görmesi için Common katmanını referencelara ekledik.
            //SqlDataProvider provider = new SqlDataProvider(AppConfigHelper.GetConnectionString("MasrafDbConnStr"));//provider classı oluştuğunda connection ile command hazır hale gelmiş oldu.

       
            string sorgu = "select  Id,Adi,Soyadi,Eposta,KullaniciAdi,SorumlusuId,PersonelTurId from Personel as P where P.KullaniciAdi=@KullaniciAdi and P.Sifre=@Sifre and P.AktifMi=1";

            provider.Command.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi);
            provider.Command.Parameters.AddWithValue("@Sifre", sifre);



            DataTable sonuc = provider.GetDataTable(sorgu);

            Personel personel = null;//şuan içi boş yani null


            if (sonuc.Rows.Count > 0)//eğer buraya girmemişse personel nesnesi boş döner metot boş değer döndürür.
            {
                DataRow dr = sonuc.Rows[0];//ilk satırı aldık

                //veriyi personel nesnesine dönüştürdük artık.
                personel = new Personel();
                personel.Id = (int)dr["Id"];//ilk satırın Id sutununu aldık
                personel.Adi = dr["Adi"].ToString();//ilk satırın Adi sutununu aldık
                personel.Soyadi = dr["Soyadi"].ToString();
                personel.Eposta = dr["Eposta"].ToString();
                personel.KullaniciAdi = dr["KullaniciAdi"].ToString();

                //SorumlusuId boşssa null ata(çünkü null alabilir int yaptık) değilse değeri ata.
               personel.SorumlusuId = dr.IsNull("SorumlusuId") == true ? null : (int?)dr["SorumlusuId"];

              
                personel.PersonelTurId = (byte)dr["PersonelTurId"];//cast ettik.



                //Not:Nullable değerler ile ilgili siteler
                //https://kodzilla.wordpress.com/2012/04/28/c-ile-bos-deger-kontrolu-null-coalescing/
                //http://www.buraksenyurt.com/post/C-2-0-ve-Nullable-Deger-Tipleri-bsenyurt-com-dan.aspx
            }

            return personel;
        }

        //SorumluId'ye göre personelleri getiricez.
        public List<Personel> GetirPersonelBySorumluId(int sorumluId)
        {
            string sorgu = "select  Id,Adi,Soyadi,Eposta,KullaniciAdi,SorumlusuId,PersonelTurId from Personel as P where  P.SorumlusuId=@SorumlusuId  and P.AktifMi=1";

            provider.Command.Parameters.Clear();//providerı globalde tanımladığım için önceden kalan parametreleri temizledim.

            provider.Command.Parameters.AddWithValue("@SorumlusuId", sorumluId);
          
            DataTable sonuc = provider.GetDataTable(sorgu);

            List<Personel> personeller = new List<Personel>();


            if (sonuc.Rows.Count > 0)//eğer buraya girmemişse personel nesnesi boş döner metot boş değer döndürür.
            {

                foreach (DataRow dr in sonuc.Rows)
                {
                    //veriyi personel nesnesine dönüştürdük artık.
                    Personel personel = new Personel();
                    personel.Id = (int)dr["Id"];//ilk satırın Id sutununu aldık
                    personel.Adi = dr["Adi"].ToString();//ilk satırın Adi sutununu aldık
                    personel.Soyadi = dr["Soyadi"].ToString();
                    personel.Eposta = dr["Eposta"].ToString();
                    personel.KullaniciAdi = dr["KullaniciAdi"].ToString();

                    //SorumlusuId boşssa null ata(çünkü null alabilir int yaptık) değilse değeri ata.
                    personel.SorumlusuId = dr.IsNull("SorumlusuId") == true ? null : (int?)dr["SorumlusuId"];


                    personel.PersonelTurId = (byte)dr["PersonelTurId"];//cast ettik.


                    personeller.Add(personel);
                }


                
            }

            return personeller;


        }


        public List<Personel> GetirTumPersonel()
        {
            string sorgu = "select  Id,Adi,Soyadi,Eposta,KullaniciAdi,SorumlusuId,PersonelTurId from Personel as P where  P.AktifMi=1";

            provider.Command.Parameters.Clear();//providerı globalde tanımladığım için önceden kalan parametreleri temizledim.

         

            DataTable sonuc = provider.GetDataTable(sorgu);

            List<Personel> personeller = new List<Personel>();


            if (sonuc.Rows.Count > 0)//eğer buraya girmemişse personel nesnesi boş döner metot boş değer döndürür.
            {

                foreach (DataRow dr in sonuc.Rows)
                {
                    //veriyi personel nesnesine dönüştürdük artık.
                    Personel personel = new Personel();
                    personel.Id = (int)dr["Id"];//ilk satırın Id sutununu aldık
                    personel.Adi = dr["Adi"].ToString();//ilk satırın Adi sutununu aldık
                    personel.Soyadi = dr["Soyadi"].ToString();
                    personel.Eposta = dr["Eposta"].ToString();
                    personel.KullaniciAdi = dr["KullaniciAdi"].ToString();

                    //SorumlusuId boşssa null ata(çünkü null alabilir int yaptık) değilse değeri ata.
                    personel.SorumlusuId = dr.IsNull("SorumlusuId") == true ? null : (int?)dr["SorumlusuId"];


                    personel.PersonelTurId = (byte)dr["PersonelTurId"];//cast ettik.


                    personeller.Add(personel);
                }



            }

            return personeller;

        }






    }
}
