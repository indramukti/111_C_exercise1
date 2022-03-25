using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace exercise1
{
    class Program
    {
         public void CreateTable()
         {
             SqlConnection con = null;
             try
             {
                 con = new SqlConnection("data source=DESKTOP-G7A7JK2\\SQL_IBD;database=Exe01;Integrated Security=TRUE");
                 con.Open();

                 SqlCommand pnj = new SqlCommand("create table Penjual (Id_Penjual char(3) primary key," +
                     "Nama_Penjual varchar(6), Jenis_Kelamin varchar(10), No_TelponPenjual Char(12))", con);
                 pnj.ExecuteNonQuery();
                 SqlCommand pmb = new SqlCommand("create table Pembeli (Id_Pembeli char(3) primary key," +
                    "Nama_Pembeli varchar(6), Jenis_Kelamin Varchar(10), No_TelponPembeli char(12))", con);
                 pmb.ExecuteNonQuery();
                 SqlCommand pdk = new SqlCommand("create table Produk ( Kode_Produk char(5) primary key," +
                    "Nama_Produk varchar(50), Harga_Produk char(50), Jumlah_Produk char(2))", con);
                 pdk.ExecuteNonQuery();
                 SqlCommand trk = new SqlCommand("create table Transaksi (Id_Transaksi char(3) primary key," +
                   " Id_Penjual char(3) foreign key references Penjual(Id_Penjual), Id_Pembeli char(3) foreign key references Pembeli(Id_Pembeli), Kode_Produk char(5) foreign key references Produk(Kode_Produk),)", con);
                 trk.ExecuteNonQuery();

                 Console.WriteLine("Tabel Berhasil Dibuat....");
                 Console.ReadKey();
             }
             catch (Exception e)
             {
                 Console.WriteLine("Gagal Membuat Tabel... " + e);
                 Console.ReadKey();
             }
             finally
             {
                 con.Close();
             }
         }

        public void InsertData()
        {

            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=DESKTOP-G7A7JK2\\SQL_IBD;database=Exe01;Integrated Security=TRUE");
                con.Open();

                SqlCommand pnj1 = new SqlCommand("insert into Penjual (Id_Penjual, Nama_Penjual, Jenis_Kelamin, No_TelponPenjual)" +
                    "values('A01','eki','Lelaki', '082252123111')", con);
                pnj1.ExecuteNonQuery();
                SqlCommand pnj2 = new SqlCommand("insert into Penjual (Id_Penjual, Nama_Penjual, Jenis_Kelamin, No_TelponPenjual)" +
                    "values('A02','eko','Lelaki', '082252123112')", con);
                pnj2.ExecuteNonQuery();
                SqlCommand pnj3 = new SqlCommand("insert into Penjual (Id_Penjual, Nama_Penjual, Jenis_Kelamin, No_TelponPenjual)" +
                    "values('A03','eku','Lelaki', '082252123113')", con);
                pnj3.ExecuteNonQuery();
                SqlCommand pnj4 = new SqlCommand("insert into Penjual (Id_Penjual, Nama_Penjual, Jenis_Kelamin, No_TelponPenjual)" +
                    "values('A04','aji','Lelaki', '082252123114')", con);
                pnj4.ExecuteNonQuery();
                SqlCommand pnj5 = new SqlCommand("insert into Penjual (Id_Penjual, Nama_Penjual, Jenis_Kelamin, No_TelponPenjual)" +
                    "values('A05','mei','Cewe', '082252123115')", con);
                pnj5.ExecuteNonQuery();

                SqlCommand pmb1 = new SqlCommand("insert into Pembeli (Id_Pembeli, Nama_Pembeli, Jenis_Kelamin, No_TelponPembeli)" +
                    "values('B01','Irsyad','Lelaki', '081343212212')", con);
                pmb1.ExecuteNonQuery();
                SqlCommand pmb2 = new SqlCommand("insert into Pembeli (Id_Pembeli, Nama_Pembeli, Jenis_Kelamin, No_TelponPembeli)" +
                    "values('B02','ican','Lelaki', '081343212214')", con);
                pmb2.ExecuteNonQuery();
                SqlCommand pmb3 = new SqlCommand("insert into Pembeli (Id_Pembeli, Nama_Pembeli, Jenis_Kelamin, No_TelponPembeli)" +
                    "values('B03','Asep','Lelaki', '081343212213')", con);
                pmb3.ExecuteNonQuery();
                SqlCommand pmb4 = new SqlCommand("insert into Pembeli (Id_Pembeli, Nama_Pembeli, Jenis_Kelamin, No_TelponPembeli)" +
                    "values('B04','asir','Lelaki', '081343212233')", con);
                pmb4.ExecuteNonQuery();
                SqlCommand pmb5 = new SqlCommand("insert into Pembeli (Id_Pembeli, Nama_Pembeli, Jenis_Kelamin, No_TelponPembeli)" +
                    "values('B05','Yusup','Lelaki', '081343212255')", con);
                pmb5.ExecuteNonQuery();


                SqlCommand pdk1 = new SqlCommand("insert into Produk (Kode_Produk, Nama_Produk, Harga_Produk, Jumlah_Produk)" +
                    "values('B0001','nastar','10.000', '1')", con);
                pdk1.ExecuteNonQuery();
                SqlCommand pdk2 = new SqlCommand("insert into Produk (Kode_Produk, Nama_Produk, Harga_Produk, Jumlah_Produk)" +
                    "values('B0002','Kacang','11.000', '1')", con);
                pdk2.ExecuteNonQuery();
                SqlCommand pdk3 = new SqlCommand("insert into Produk (Kode_Produk, Nama_Produk, Harga_Produk, Jumlah_Produk)" +
                    "values('B0003','Klepon','3.000', '1')", con);
                pdk3.ExecuteNonQuery();
                SqlCommand pdk4 = new SqlCommand("insert into Produk (Kode_Produk, Nama_Produk, Harga_Produk, Jumlah_Produk)" +
                    "values('B0004','cucur','10.000', '3')", con);
                pdk4.ExecuteNonQuery();
                SqlCommand pdk5 = new SqlCommand("insert into Produk (Kode_Produk, Nama_Produk, Harga_Produk, Jumlah_Produk)" +
                    "values('B0005','risol','10.000', '4')", con);
                pdk5.ExecuteNonQuery();

                SqlCommand trk1 = new SqlCommand("insert into Transaksi (Id_Transaksi, Id_Penjual, Id_Pembeli,  Kode_Produk)" +
                    "values('T01','A01','B01','B0001')", con);
                trk1.ExecuteNonQuery();
                SqlCommand trk2 = new SqlCommand("insert into Transaksi (Id_Transaksi, Id_Penjual, Id_Pembeli,  Kode_Produk)" +
                    "values('T02','A02','B02','B0002')", con);
                trk2.ExecuteNonQuery();
                SqlCommand trk3 = new SqlCommand("insert into Transaksi (Id_Transaksi, Id_Penjual, Id_Pembeli,  Kode_Produk)" +
                    "values('T03','A03','B03','B0003')", con);
                trk3.ExecuteNonQuery();
                SqlCommand trk4 = new SqlCommand("insert into Transaksi (Id_Transaksi, Id_Penjual, Id_Pembeli,  Kode_Produk)" +
                    "values('T04','A04','B04','B0004')", con);
                trk4.ExecuteNonQuery();
                SqlCommand trk5 = new SqlCommand("insert into Transaksi (Id_Transaksi, Id_Penjual, Id_Pembeli,  Kode_Produk)" +
                    "values('T05','A05','B05','B0004')", con);
                trk5.ExecuteNonQuery();

                Console.WriteLine("Data berhasil Di input...");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Gagal Menginput data... " + e);
                Console.ReadKey();
            }
            finally
            {
                con.Close();
            }
        }
        static void Main(string[] args)
        {
            //new Program().CreateTable();
            new Program().InsertData();
        }
    }
}
