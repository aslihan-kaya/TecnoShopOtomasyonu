create proc SListele
as begin 
select * from Subeler
end

create proc SEkle 
@SubeAdi varchar(50),
@Subeil varchar(50),
@Subeilce varchar(50)
as begin 
insert into Subeler(SubeAdi,Subeil,Subeilce)
values(@SubeAdi,@Subeil,@Subeilce)
end

create proc SYenile
@SubeNo int,
@SubeAdi varchar(50),
@Subeil varchar(50),
@Subeilce varchar(50)
as begin 
update Subeler set SubeAdi=@SubeAdi,Subeil=@Subeil,Subeilce=@Subeilce where SubeNo=@SubeNo
end

create proc SSil
@SubeNo int
as begin 
delete from Subeler where SubeNo=@SubeNo
end

create proc PListele
as begin 
select * from Personeller
end

create proc PEkle 
@PersonelAdi varchar(50),
@Telefon int,
@Adres varchar(50),
@Maas money,
@Prim money,
@SubeNo int
as begin 
insert into Personeller(PersonelAdi,Telefon,Adres,Maas,Prim,SubeNo)
values(@PersonelAdi,@Telefon,@Adres, @Maas,@Prim,@SubeNo)
end

create proc PYenile
@PersonelNo int,
@PersonelAdi varchar(50),
@Telefon int,
@Adres varchar(50),
@Maas money,
@Prim money,
@SubeNo int
as begin 
update Personeller set PersonelAdi=@PersonelAdi,Telefon=@Telefon,Adres=@Adres, Maas=@Maas,Prim=@Prim,SubeNo=@SubeNo where PersonelNo=@PersonelNo
end

create proc PSil
@PersonelNo int
as begin 
delete from Personeller where PersonelNo=@PersonelNo
end

create proc MListele
as begin 
select * from Musteriler
end

create proc MEkle 
@MusteriAdi varchar(50),
@MTelefon int,
@MAdres varchar(50),
@PersonelNo int
as begin 
insert into Musteriler(MusteriAdi,MTelefon,MAdres,PersonelNo)
values(@MusteriAdi,@MTelefon,@MAdres,@PersonelNo)
end

create proc MYenile
@MusteriNo int,
@MusteriAdi varchar(50),
@MTelefon int,
@MAdres varchar(50),
@PersonelNo int
as begin 
update Musteriler set MusteriAdi=@MusteriAdi,MTelefon=@MTelefon,MAdres=@MAdres, PersonelNo=@PersonelNo where MusteriNo=@MusteriNo
end

create proc MSil
@MusteriNo int
as begin 
delete from Musteriler where MusteriNo=@MusteriNo
end


create proc UListele
as begin 
select * from Urunler
end

create proc UEkle 
@UrunTipi varchar(50),
@UrunAdi varchar(50),
@UrunFiyat money,
@MusteriNo int
as begin 
insert into Urunler(UrunTipi,UrunAdi,UrunFiyat,MusteriNo)
values(@UrunTipi,@UrunAdi,@UrunFiyat,@MusteriNo)
end

create proc UYenile
@UrunNo int,
@UrunTipi varchar(50),
@UrunAdi varchar(50),
@UrunFiyat money,
@MusteriNo int
as begin 
update Urunler set UrunTipi=@UrunTipi,UrunAdi=@UrunAdi,UrunFiyat=@UrunFiyat, MusteriNo=@MusteriNo where UrunNo=@UrunNo
end

create proc USil
@UrunNo int
as begin 
delete from Urunler where UrunNo=@UrunNo
end
