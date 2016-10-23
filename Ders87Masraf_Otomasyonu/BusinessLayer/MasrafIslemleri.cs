using DataAccessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class MasrafIslemleri
    {
        private SqlDataProvider provider = new SqlDataProvider(Constants.ConnectionString);

        public int MasrafEkle(Masraf masraf) 
        {
          

            string sorgu = "Insert into Masraf Values(@Id,@Baslik,@Tarih,@Tutar,@Aciklama,@PersonelId,@DurumId)";


            provider.Command.Parameters.Clear();//önceden yazdığımız parametreleri silmiş oluyoruz

            provider.Command.Parameters.AddWithValue("@Id", masraf.Id);
            //provider.Command.Parameters.AddWithValue("@Id", Guid.NewGuid());//benzersiz sayı ürettik.
            provider.Command.Parameters.AddWithValue("@Baslik", masraf.Baslik);
            provider.Command.Parameters.AddWithValue("@Tarih", masraf.Tarih);
            provider.Command.Parameters.AddWithValue("@Tutar", masraf.Tutar);
            provider.Command.Parameters.AddWithValue("@Aciklama", masraf.Aciklama);
            provider.Command.Parameters.AddWithValue("@PersonelId", masraf.PersonelId);
            provider.Command.Parameters.AddWithValue("@DurumId", masraf.DurumId);


           int etkilenenSatirSayisi= provider.RunQuery(sorgu);

           return etkilenenSatirSayisi;
        }



        public List<Masraf> GetirMasraflar(int personelId)
        {
            List<Masraf> masraflar = new List<Masraf>();

            string sorgu = "Select Id,Baslik,Tarih,Tutar,Aciklama,PersonelId,DurumId from Masraf where PersonelId=@PersonelId";

                 provider.Command.Parameters.Clear();//önceden yazdığımız parametreleri silmiş oluyoruz.çünkü yukarıdaki metottan parametre kalmış olabilir onları siliyoruz

                 provider.Command.Parameters.AddWithValue("@PersonelId", personelId);

                 DataTable dt = provider.GetDataTable(sorgu);

                 if (dt.Rows.Count>0)//bize masraflar dönmüş demektir.
                 {
                     foreach (DataRow dr in dt.Rows)//dt.Rows içinde DataRow barındıran bir listedir.bu listenin içinde geziyoruz.(dr her bir satır oluyor.dr[0] ilk kolon ,dr[1] ikinci kolon oluyor veya dr["Baslik"] Baslik kolonu,dr["Aciklama"] kolonu gibi).
                     {

                         Masraf masraf = new Masraf 
                         {
                         Id=new Guid(dr["Id"].ToString()),//benzersiz sayı üretir.
                         Baslik=dr["Baslik"].ToString(),
                         Aciklama=dr["Aciklama"].ToString(),
                         Tarih=(DateTime)dr["Tarih"],// dr["Tarih"] bir obje olduğu için bizde cast ettik.
                         Tutar = (decimal)dr["Tutar"],// dr["Tutar"] bir obje olduğu için bizde cast 
                         PersonelId=(int)dr["PersonelId"],
                         DurumId=(byte)dr["DurumId"]
                         };

                         masraflar.Add(masraf);

                     }
                 }

                 return masraflar;

        }



        public int MasrafGuncelle(Masraf masraf) 
        {
            string sorgu = "Update  Masraf  set Baslik=@Baslik,Tarih=@Tarih,Tutar=@Tutar,Aciklama=@Aciklama,DurumId=@DurumId where Id=@Id";
                     
                

            provider.Command.Parameters.Clear();//önceden yazdığımız parametreleri silmiş oluyoruz

            provider.Command.Parameters.AddWithValue("@Id", masraf.Id);
            //provider.Command.Parameters.AddWithValue("@Id", Guid.NewGuid());//benzersiz sayı ürettik.
            provider.Command.Parameters.AddWithValue("@Baslik", masraf.Baslik);
            provider.Command.Parameters.AddWithValue("@Tarih", masraf.Tarih);
            provider.Command.Parameters.AddWithValue("@Tutar", masraf.Tutar);
            provider.Command.Parameters.AddWithValue("@Aciklama", masraf.Aciklama);           
            provider.Command.Parameters.AddWithValue("@DurumId", masraf.DurumId);


            int etkilenenSatirSayisi = provider.RunQuery(sorgu);

            return etkilenenSatirSayisi;
        
        
        
        }



        public int MasrafSil(Masraf masraf)
        {
            string sorgu = "Delete from Masraf  where Id=@Id";



            provider.Command.Parameters.Clear();//önceden yazdığımız parametreleri silmiş oluyoruz

            provider.Command.Parameters.AddWithValue("@Id", masraf.Id);
           


            int etkilenenSatirSayisi = provider.RunQuery(sorgu);

            return etkilenenSatirSayisi;
        }
    }
}
